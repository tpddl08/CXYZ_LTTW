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
    public partial class frmBaoHanh : Sunny.UI.UIForm
    {
        databaseDataContext db = new databaseDataContext();
        public frmBaoHanh()
        {
            InitializeComponent();
        }

        private void formBaoHanh_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            dgvBaohanh.CellEndEdit += dgvBaohanh_CellEndEdit;
        }
        private void loadDuLieu()
        {
            dgvBaohanh.Rows.Clear();
            var query = from bh in db.BaoHanhs
                        select bh;

            foreach (var item in query.ToList())
            {
                int rowIndex = dgvBaohanh.Rows.Add(item.IMEI, item.MaKH, item.NgayNhan, item.MoTaLoi, item.TinhTrangXuLy);
            }
        }

        private void dgvBaohanh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvBaohanh.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            // Lấy trạng thái hiện tại của dòng
            string currentTag = row.Tag as string;

            // Nếu dòng đang được đánh dấu để xóa (D), thì không làm gì cả
            if (currentTag == "D") return;
            row.Tag = "M";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int newRowIndex = dgvBaohanh.Rows.Add("", "", "", "");
            dgvBaohanh.CurrentCell = dgvBaohanh.Rows[newRowIndex].Cells["IMEI"];  // Focus vào cột IMEI
            dgvBaohanh.BeginEdit(true);  // Bắt đầu edit trực tiếp

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBaohanh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvBaohanh.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    string tag = row.Tag as string;
                    if (tag == "N")
                    {
                        // row mới chưa lưu: remove khỏi grid trực tiếp
                        dgvBaohanh.Rows.Remove(row);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBaohanh.EndEdit();
                dgvBaohanh.CommitEdit(DataGridViewDataErrorContexts.Commit);

                // --- XỬ LÝ XÓA ---
                var deletes = new List<string>();
                foreach (DataGridViewRow row in dgvBaohanh.Rows)
                {
                    if ((row.Tag as string) == "D")
                    {
                        var ten = row.Cells["IMEI"].Value?.ToString();
                        if (!string.IsNullOrEmpty(ten)) deletes.Add(ten);
                    }
                }
                foreach (var ten in deletes.Distinct())
                {
                    var entity = db.BaoHanhs.SingleOrDefault(t => t.IMEI == ten);
                    if (entity != null) db.BaoHanhs.DeleteOnSubmit(entity);
                }

                // --- XỬ LÝ THÊM MỚI VÀ CẬP NHẬT ---
                foreach (DataGridViewRow row in dgvBaohanh.Rows)
                {
                    if (row.IsNewRow || (row.Tag as string) == "D") continue; // Bỏ qua dòng mới, dòng đã xóa

                    string IMEI = row.Cells["IMEI"].Value?.ToString()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(IMEI))
                    {
                        MessageBox.Show($"IMEI ở dòng {row.Index + 1} không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string maKHStr = row.Cells["MaKH"].Value?.ToString()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(maKHStr))
                    {
                        MessageBox.Show($"MaKH ở dòng {row.Index + 1} không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int maKH;
                    if (!int.TryParse(maKHStr, out maKH))
                    {
                        MessageBox.Show($"MaKH ở dòng {row.Index + 1} không hợp lệ (phải là số nguyên).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string ngayNhanStr = row.Cells["NgayNhan"].Value?.ToString()?.Trim() ?? "";
                    DateTime? ngayNhan = null;
                    if (!string.IsNullOrEmpty(ngayNhanStr))
                    {
                        DateTime temp;
                        if (DateTime.TryParse(ngayNhanStr, out temp))
                        {
                            ngayNhan = temp;
                        }
                        else
                        {
                            MessageBox.Show($"NgayNhan ở dòng {row.Index + 1} không hợp lệ (định dạng ngày tháng không đúng).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (!db.ChiTietSanPham_IMEIs.Any(i => i.IMEI == IMEI))
                    {
                        MessageBox.Show($"IMEI '{IMEI}' ở dòng {row.Index + 1} không tồn tại trong bảng ChiTietSanPham_IMEI.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!db.KhachHangs.Any(k => k.MaKH == maKH))
                    {
                        MessageBox.Show($"MaKH '{maKH}' ở dòng {row.Index + 1} không tồn tại trong bảng KhachHang.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tìm đối tượng trong DataContext bằng khóa chính
                    var entity = db.BaoHanhs.SingleOrDefault(t => t.IMEI == IMEI);

                    if (entity == null) // Nếu không tìm thấy trong DB => Đây là bản ghi MỚI
                    {
                        // Kiểm tra lại lần nữa để chắc chắn không có bản ghi nào đã được đăng ký
                        var pendingInserts = db.GetChangeSet().Inserts.OfType<BaoHanh>();
                        if (pendingInserts.Any(i => i.IMEI == IMEI))
                        {
                            continue; // Bỏ qua nếu đã được xử lý
                        }

                        // Tạo đối tượng mới và đăng ký để INSERT
                        var bh = new BaoHanh
                        {
                            IMEI = IMEI,
                            MaKH = maKH,
                            NgayNhan = ngayNhan,
                            MoTaLoi = row.Cells["MoTaLoi"].Value?.ToString() ?? "",
                            TinhTrangXuLy = row.Cells["TinhTrangXuLy"].Value?.ToString() ?? ""
                        };
                        db.BaoHanhs.InsertOnSubmit(bh);
                    }
                    else // Nếu tìm thấy => Đây là bản ghi CŨ cần UPDATE
                    {
                        // Chỉ cập nhật nếu dòng được đánh dấu là đã sửa đổi "M"
                        if ((row.Tag as string) == "M")
                        {
                            entity.MaKH = maKH;
                            entity.NgayNhan = ngayNhan;
                            entity.MoTaLoi = row.Cells["MoTaLoi"].Value?.ToString() ?? "";
                            entity.TinhTrangXuLy = row.Cells["TinhTrangXuLy"].Value?.ToString() ?? "";
                        }
                    }
                }

                // Commit tất cả các thay đổi một lần
                db.SubmitChanges();

                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu để đồng bộ hóa và reset các Tag
                loadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
