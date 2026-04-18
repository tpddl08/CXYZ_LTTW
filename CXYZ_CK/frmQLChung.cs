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
    public partial class frmQLChung : Sunny.UI.UIForm
    {
        databaseDataContext db = new databaseDataContext();
        public frmQLChung()
        {
            InitializeComponent();
        }

        private void formQLChung_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            dgvHangsanxuat.CellEndEdit += dgvHangsanxuat_CellEndEdit;
        }

        private void loadDuLieu()
        {
            dgvHangsanxuat.Rows.Clear();
            var query = from hsx in db.HangSanXuats
                        select hsx;

            foreach (var item in query.ToList())
            {
                // Thêm row thủ công: MaHSX, TenHSX, DiaChiVN, SoDienThoaiVN
                int rowIndex = dgvHangsanxuat.Rows.Add(item.MaHSX, item.TenHSX, item.DiaChiVN, item.SoDienThoaiVN);
            }
        }

        private void dgvHangsanxuat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvHangsanxuat.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            // Lấy trạng thái hiện tại của dòng
            string currentTag = row.Tag as string;

            // Nếu dòng đang được đánh dấu để xóa (D), thì không làm gì cả
            if (currentTag == "D") return;
            row.Tag = "M";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int newRowIndex = dgvHangsanxuat.Rows.Add("", "", "", "");
            dgvHangsanxuat.CurrentCell = dgvHangsanxuat.Rows[newRowIndex].Cells["MaHSX"];  // Focus vào cột MaHSX
            dgvHangsanxuat.BeginEdit(true);  // Bắt đầu edit trực tiếp
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHangsanxuat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvHangsanxuat.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    string tag = row.Tag as string;
                    if (tag == "N")
                    {
                        // row mới chưa lưu: remove khỏi grid trực tiếp
                        dgvHangsanxuat.Rows.Remove(row);
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
                dgvHangsanxuat.EndEdit();
                dgvHangsanxuat.CommitEdit(DataGridViewDataErrorContexts.Commit);

                // --- XỬ LÝ XÓA ---
                var deletes = new List<string>();
                foreach (DataGridViewRow row in dgvHangsanxuat.Rows)
                {
                    if ((row.Tag as string) == "D")
                    {
                        var ten = row.Cells["MaHSX"].Value?.ToString();
                        if (!string.IsNullOrEmpty(ten)) deletes.Add(ten);
                    }
                }
                foreach (var ten in deletes.Distinct())
                {
                    var entity = db.HangSanXuats.SingleOrDefault(t => t.MaHSX == ten);
                    if (entity != null) db.HangSanXuats.DeleteOnSubmit(entity);
                }

                // --- XỬ LÝ THÊM MỚI VÀ CẬP NHẬT ---
                foreach (DataGridViewRow row in dgvHangsanxuat.Rows)
                {
                    if (row.IsNewRow || (row.Tag as string) == "D") continue; // Bỏ qua dòng mới, dòng đã xóa

                    string maHSX = row.Cells["MaHSX"].Value?.ToString()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(maHSX))
                    {
                        MessageBox.Show($"Mã hãng sản xuất ở dòng {row.Index + 1} không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tìm đối tượng trong DataContext bằng khóa chính
                    var entity = db.HangSanXuats.SingleOrDefault(t => t.MaHSX == maHSX);

                    if (entity == null) // Nếu không tìm thấy trong DB => Đây là bản ghi MỚI
                    {
                        // Kiểm tra lại lần nữa để chắc chắn không có bản ghi nào đã được đăng ký
                        var pendingInserts = db.GetChangeSet().Inserts.OfType<HangSanXuat>();
                        if (pendingInserts.Any(i => i.MaHSX == maHSX))
                        {
                            continue; // Bỏ qua nếu đã được xử lý
                        }

                        // Tạo đối tượng mới và đăng ký để INSERT
                        var hsx = new HangSanXuat
                        {
                            MaHSX = maHSX,
                            TenHSX = row.Cells["TenHSX"].Value?.ToString() ?? "",
                            DiaChiVN = row.Cells["DiaChiVN"].Value?.ToString() ?? "",
                            SoDienThoaiVN = row.Cells["SoDienThoaiVN"].Value?.ToString() ?? ""
                        };
                        db.HangSanXuats.InsertOnSubmit(hsx);
                    }
                    else // Nếu tìm thấy => Đây là bản ghi CŨ cần UPDATE
                    {
                        // Chỉ cập nhật nếu dòng được đánh dấu là đã sửa đổi "M"
                        if ((row.Tag as string) == "M")
                        {
                            entity.TenHSX = row.Cells["TenHSX"].Value?.ToString() ?? "";
                            entity.DiaChiVN = row.Cells["DiaChiVN"].Value?.ToString() ?? "";
                            entity.SoDienThoaiVN = row.Cells["SoDienThoaiVN"].Value?.ToString() ?? "";
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

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            frmNhapHang formnh= new frmNhapHang();
            formnh.ShowDialog();

        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmQLSP formQLSP = new frmQLSP();
            formQLSP.ShowDialog();
        }

        private void btnQLBH_Click(object sender, EventArgs e)
        {
            frmBaoHanh formbh = new frmBaoHanh();
            formbh.ShowDialog();
        }
    }
}
