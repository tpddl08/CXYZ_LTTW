using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXYZ_CK
{
    public partial class frmQLSP : Sunny.UI.UIForm
    {
        databaseDataContext db = new databaseDataContext();
        public frmQLSP()
        {
            InitializeComponent();
        }

        private void formQLSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiDienThoaiDataSet1.HangSanXuat' table. You can move, or remove it, as needed.
            this.hangSanXuatTableAdapter.Fill(this.quanLiDienThoaiDataSet1.HangSanXuat);
            loadDuLieu();
            dgvQLDienthoai.CellEndEdit += dgvTK_CellEndEdit;
        }

        private void loadDuLieu()
        {
            dgvQLDienthoai.Rows.Clear();
            var query = from dt in db.DienThoais  // Bảng TaiKhoan
                        join hsx in db.HangSanXuats on dt.MaHSX equals hsx.MaHSX  // Join qua FK (DLINQ query)
                        select new  // Anonymous type (LINQ select - theo slide)
                        {
                            MaSP = dt.MaSP,  // MSNV
                            TenSP = dt.TenSP,    // Tên
                            MaHSX = dt.MaHSX,
                            TenHSX = hsx.TenHSX,          // Mật khẩu
                            SoLuong = dt.SoLuong,    // Để bind ComboBox (ID)
                            Gia = dt.Gia  // Hiển thị tên loại (từ join)
                        };

            foreach (var item in query.ToList())
            {
                int rowIndex = dgvQLDienthoai.Rows.Add(item.MaSP, item.TenSP, item.TenHSX, item.SoLuong, item.Gia);
                dgvQLDienthoai.Rows[rowIndex].Cells["TenHSX"].Value = item.MaHSX;
            }

        }

        private void dgvTK_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvQLDienthoai.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            // Lấy trạng thái hiện tại của dòng
            string currentTag = row.Tag as string;

            // Nếu dòng đang được đánh dấu để xóa (D), thì không làm gì cả
            if (currentTag == "D") return;
            row.Tag = "M";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int newRowIndex = dgvQLDienthoai.Rows.Add("", "", "", "");
            dgvQLDienthoai.CurrentCell = dgvQLDienthoai.Rows[newRowIndex].Cells["MaSP"];  // Focus vào cột MaHSX
            dgvQLDienthoai.BeginEdit(true);  // Bắt đầu edit trực tiếp
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvQLDienthoai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvQLDienthoai.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    string tag = row.Tag as string;
                    if (tag == "N")
                    {
                        // row mới chưa lưu: remove khỏi grid trực tiếp
                        dgvQLDienthoai.Rows.Remove(row);
                    }
                    else
                    {
                        // đánh dấu xóa và ẩn (thực hiện xóa DB khi bấm Save)
                        row.Tag = "D";
                        row.Visible = false;
                    }
                }
                MessageBox.Show("Đã xóa. Bấm Lưu để áp dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dgvQLDienthoai.EndEdit();
                dgvQLDienthoai.CommitEdit(DataGridViewDataErrorContexts.Commit);

                // --- 1) XÓA SẢN PHẨM (nếu có) và xóa IMEI liên quan ---
                var deletes = new List<string>();
                foreach (DataGridViewRow row in dgvQLDienthoai.Rows)
                {
                    if ((row.Tag as string) == "D")
                    {
                        var maSP = row.Cells["MaSP"].Value?.ToString();
                        if (!string.IsNullOrEmpty(maSP)) deletes.Add(maSP);
                    }
                }

                foreach (var maSP in deletes.Distinct())
                {
                    // xóa tất cả IMEI của sản phẩm trước
                    var imeis = db.ChiTietSanPham_IMEIs.Where(i => i.MaSP == maSP).ToList();
                    foreach (var im in imeis) db.ChiTietSanPham_IMEIs.DeleteOnSubmit(im);

                    var entity = db.DienThoais.SingleOrDefault(t => t.MaSP == maSP);
                    if (entity != null) db.DienThoais.DeleteOnSubmit(entity);
                }

                // --- 2) THÊM MỚI / CẬP NHẬT và tạo IMEI nếu số lượng tăng ---
                foreach (DataGridViewRow row in dgvQLDienthoai.Rows)
                {
                    if (row.IsNewRow || (row.Tag as string) == "D") continue;

                    string maSP = row.Cells["MaSP"].Value?.ToString()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(maSP))
                    {
                        MessageBox.Show($"MaSP ở dòng {row.Index + 1} không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (maSP.Length != 4)
                    {
                        MessageBox.Show($"MaSP ở dòng {row.Index + 1} phải có đúng 4 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string tenSP = row.Cells["TenSP"].Value?.ToString()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(tenSP))
                    {
                        MessageBox.Show($"TenSP ở dòng {row.Index + 1} không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string maHSX = row.Cells["TenHSX"].Value?.ToString()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(maHSX))
                    {
                        MessageBox.Show($"MaHSX ở dòng {row.Index + 1} không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string soLuongStr = row.Cells["SoLuong"].Value?.ToString()?.Trim() ?? "";
                    int soLuong;
                    if (!int.TryParse(soLuongStr, out soLuong) || soLuong < 0)
                    {
                        MessageBox.Show($"SoLuong ở dòng {row.Index + 1} không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string giaStr = row.Cells["Gia"].Value?.ToString()?.Trim() ?? "";
                    double gia;
                    if (!double.TryParse(giaStr, out gia) || gia < 0)
                    {
                        MessageBox.Show($"Gia ở dòng {row.Index + 1} không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // kiểm tra MaHSX tồn tại
                    if (!db.HangSanXuats.Any(h => h.MaHSX == maHSX))
                    {
                        MessageBox.Show($"MaHSX '{maHSX}' ở dòng {row.Index + 1} không tồn tại trong HangSanXuat.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // tìm entity DienThoai
                    var entity = db.DienThoais.SingleOrDefault(t => t.MaSP == maSP);
                    if (entity == null)
                    {
                        // thêm mới DienThoai
                        var dt = new DienThoai
                        {
                            MaSP = maSP,
                            TenSP = tenSP,
                            MaHSX = maHSX,
                            SoLuong = soLuong,
                            Gia = (float)gia,
                            Ram = 0, // nếu có trường bắt buộc khác, điều chỉnh tương ứng (nếu DB bắt buộc, bạn cần cung cấp hoặc set giá trị mặc định)
                            BoNho = 0
                        };
                        db.DienThoais.InsertOnSubmit(dt);

                        // tạo IMEI bằng số lượng soLuong
                        int lastIndex = 0;
                        var existImeis = db.ChiTietSanPham_IMEIs.Where(i => i.MaSP == maSP).Select(i => i.IMEI).ToList();
                        if (existImeis.Any())
                        {
                            foreach (var s in existImeis)
                            {
                                if (s != null && s.Length > maSP.Length)
                                {
                                    string suf = s.Substring(maSP.Length);
                                    int parsed;
                                    if (int.TryParse(suf, out parsed) && parsed > lastIndex) lastIndex = parsed;
                                }
                            }
                        }

                        for (int k = 1; k <= soLuong; k++)
                        {
                            string newImei = maSP + (lastIndex + k).ToString("D4");
                            // an toàn: kiểm tra trùng (nếu trùng, tăng lastIndex cho tới khi không trùng)
                            while (db.ChiTietSanPham_IMEIs.Any(i => i.IMEI == newImei))
                            {
                                lastIndex++;
                                newImei = maSP + (lastIndex + k).ToString("D4");
                            }

                            var ctim = new ChiTietSanPham_IMEI
                            {
                                IMEI = newImei,
                                MaSP = maSP,
                                GiaNhap = (float)gia,    // lưu Gia nhập bằng giá hiện tại (bạn thay đổi nếu cần)
                                TinhTrang = "Trong kho"
                            };
                            db.ChiTietSanPham_IMEIs.InsertOnSubmit(ctim);
                        }
                    }
                    else
                    {
                        // cập nhật thông tin (nếu cần)
                        if ((row.Tag as string) == "M" || entity.TenSP != tenSP || entity.MaHSX != maHSX || entity.Gia != (float)gia)
                        {
                            entity.TenSP = tenSP;
                            entity.MaHSX = maHSX;
                            entity.Gia = (float)gia;
                        }

                        int oldQty = entity.SoLuong;
                        if (soLuong > oldQty)
                        {
                            int need = soLuong - oldQty;

                            // tìm lastIndex từ các IMEI hiện có
                            int lastIndex = 0;
                            var existImeis = db.ChiTietSanPham_IMEIs.Where(i => i.MaSP == maSP).Select(i => i.IMEI).ToList();
                            if (existImeis.Any())
                            {
                                foreach (var s in existImeis)
                                {
                                    if (s != null && s.Length > maSP.Length)
                                    {
                                        string suf = s.Substring(maSP.Length);
                                        int parsed;
                                        if (int.TryParse(suf, out parsed) && parsed > lastIndex) lastIndex = parsed;
                                    }
                                }
                            }

                            for (int k = 1; k <= need; k++)
                            {
                                string newImei = maSP + (lastIndex + k).ToString("D4");
                                while (db.ChiTietSanPham_IMEIs.Any(i => i.IMEI == newImei))
                                {
                                    lastIndex++;
                                    newImei = maSP + (lastIndex + k).ToString("D4");
                                }

                                var ctim = new ChiTietSanPham_IMEI
                                {
                                    IMEI = newImei,
                                    MaSP = maSP,
                                    GiaNhap = (float)gia,
                                    TinhTrang = "Trong kho"
                                };
                                db.ChiTietSanPham_IMEIs.InsertOnSubmit(ctim);
                            }

                            entity.SoLuong = soLuong;
                        }
                        else if (soLuong < oldQty)
                        {
                            int toRemove = oldQty - soLuong;
                            // chỉ xóa IMEI còn Trong kho
                            var candidates = db.ChiTietSanPham_IMEIs
                                               .Where(i => i.MaSP == maSP && i.TinhTrang == "Trong kho")
                                               .OrderByDescending(i => i.IMEI)
                                               .Take(toRemove)
                                               .ToList();

                            if (candidates.Count < toRemove)
                            {
                                MessageBox.Show($"Không thể giảm SoLuong cho {maSP}: chỉ có {candidates.Count} IMEI 'Trong kho', nhưng cần giảm {toRemove}.", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            foreach (var rm in candidates)
                            {
                                db.ChiTietSanPham_IMEIs.DeleteOnSubmit(rm);
                            }

                            entity.SoLuong = soLuong;
                        }
                        // nếu bằng thì không thay đổi số lượng
                    }
                }

                // --- 3) Commit một lần ---
                db.SubmitChanges();

                MessageBox.Show("Đã lưu dữ liệu thành công (IMEI được tạo/xóa tương ứng).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
