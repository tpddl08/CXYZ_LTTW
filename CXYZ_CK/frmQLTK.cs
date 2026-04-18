using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny;
using System.Security.Cryptography;

namespace CXYZ_CK
{
    public partial class frmQLTK : Sunny.UI.UIForm
    {
        databaseDataContext db = new databaseDataContext();
        public frmQLTK()
        {
            InitializeComponent();
        }

        private void formQLTK_Load(object sender, EventArgs e)
        {
            this.loaiTaiKhoanTableAdapter.Fill(this.quanLiDienThoaiDataSet.LoaiTaiKhoan);
            loadDuLieu();
            dgvTaikhoan.CellEndEdit += dgvTK_CellEndEdit;
        }

        private void loadDuLieu()
        {
            dgvTaikhoan.Rows.Clear();
            var query = from tk in db.TaiKhoans
                        join lt in db.LoaiTaiKhoans on tk.MaTaiKhoan equals lt.MaTaiKhoan
                        select new
                        {
                            TenDangNhap = tk.TenDangNhap,
                            MatKhau = tk.MatKhau, // Giữ nguyên byte[]
                            Email = tk.Email,
                            MaTaiKhoan = tk.MaTaiKhoan,
                            TenLoaiTaiKhoan = lt.TenLoaiTaiKhoan
                        };
            var results = query.ToList(); // Execute query trên DB trước
            foreach (var item in results)
            {
                string matKhauHex = item.MatKhau != null ? BitConverter.ToString(item.MatKhau.ToArray()).Replace("-", "") : "";
                int rowIndex = dgvTaikhoan.Rows.Add(item.TenDangNhap, matKhauHex, item.Email, item.TenLoaiTaiKhoan);
                dgvTaikhoan.Rows[rowIndex].Cells["LoaiTaiKhoan"].Value = item.MaTaiKhoan;
            }

        }

        private void dgvTK_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvTaikhoan.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            // Lấy trạng thái hiện tại của dòng
            string currentTag = row.Tag as string;

            // Nếu dòng đang được đánh dấu để xóa (D), thì không làm gì cả
            if (currentTag == "D") return;
            row.Tag = "M";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvTaikhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvTaikhoan.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    string tag = row.Tag as string;
                    if (tag == "N")
                    {
                        // row mới chưa lưu: remove khỏi grid trực tiếp
                        dgvTaikhoan.Rows.Remove(row);
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            int newRowIndex = dgvTaikhoan.Rows.Add("", "", "", null);
            var row = dgvTaikhoan.Rows[newRowIndex];
            dgvTaikhoan.CurrentCell = row.Cells["TenDangNhap"];
            dgvTaikhoan.BeginEdit(true);
        }

        private void searchTxtB_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTxtB.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvTaikhoan.Rows)
            {
                if (row.IsNewRow) continue;  // Bỏ qua row thêm mới

                string tenHienThi = row.Cells["TenHienThi"].Value?.ToString().ToLower() ?? "";
                string tenDangNhap = row.Cells["TenDangNhap"].Value?.ToString().ToLower() ?? "";

                if (string.IsNullOrEmpty(searchTerm) || tenHienThi.Contains(searchTerm) || tenDangNhap.Contains(searchTerm))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTaikhoan.EndEdit();
                dgvTaikhoan.CommitEdit(DataGridViewDataErrorContexts.Commit);

                // --- XỬ LÝ XÓA ---
                var deletes = new List<string>();
                foreach (DataGridViewRow row in dgvTaikhoan.Rows)
                {
                    if ((row.Tag as string) == "D")
                    {
                        var ten = row.Cells["TenDangNhap"].Value?.ToString();
                        if (!string.IsNullOrEmpty(ten)) deletes.Add(ten);
                    }
                }
                foreach (var ten in deletes.Distinct())
                {
                    var entity = db.TaiKhoans.SingleOrDefault(t => t.TenDangNhap == ten);
                    if (entity != null) db.TaiKhoans.DeleteOnSubmit(entity);
                }

                // --- XỬ LÝ THÊM MỚI VÀ CẬP NHẬT ---
                foreach (DataGridViewRow row in dgvTaikhoan.Rows)
                {
                    if (row.IsNewRow || (row.Tag as string) == "D") continue;
                    string tenDangNhap = row.Cells["TenDangNhap"].Value?.ToString()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(tenDangNhap))
                    {
                        MessageBox.Show($"Tên đăng nhập ở dòng {row.Index + 1} không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string matKhauStr = row.Cells["MatKhau"].Value?.ToString()?.Trim() ?? "";
                    string email = row.Cells["Email"].Value?.ToString()?.Trim() ?? "";
                    int maTaiKhoan = Convert.ToInt32(row.Cells["LoaiTaiKhoan"].Value ?? 1); // Mặc định 1 nếu null

                    var entity = db.TaiKhoans.SingleOrDefault(t => t.TenDangNhap == tenDangNhap);
                    if (entity == null) // Thêm mới
                    {
                        var pendingInserts = db.GetChangeSet().Inserts.OfType<TaiKhoan>();
                        if (pendingInserts.Any(i => i.TenDangNhap == tenDangNhap)) continue;

                        // Hash MatKhau nếu có
                        byte[] matKhauHash = null;
                        if (!string.IsNullOrEmpty(matKhauStr))
                        {
                            using (MD5 md5 = MD5.Create())
                            {
                                matKhauHash = md5.ComputeHash(Encoding.ASCII.GetBytes(matKhauStr));
                            }
                        }

                        var tk = new TaiKhoan
                        {
                            TenDangNhap = tenDangNhap,
                            MatKhau = matKhauHash ?? new byte[0], // Mặc định byte rỗng nếu không nhập
                            Email = email,
                            MaTaiKhoan = maTaiKhoan
                            // Các trường khác như RandomKey, OTP nếu cần mặc định null
                        };
                        db.TaiKhoans.InsertOnSubmit(tk);
                    }
                    else // Update
                    {
                        if ((row.Tag as string) == "M")
                        {
                            // Chỉ hash MatKhau nếu thay đổi (giả sử nếu không rỗng)
                            if (!string.IsNullOrEmpty(matKhauStr))
                            {
                                using (MD5 md5 = MD5.Create())
                                {
                                    entity.MatKhau = md5.ComputeHash(Encoding.ASCII.GetBytes(matKhauStr));
                                }
                            }
                            entity.Email = email;
                            entity.MaTaiKhoan = maTaiKhoan;
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
    }
}