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
    public partial class frmNhapHang : Sunny.UI.UIForm
    {
        databaseDataContext db = new databaseDataContext();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void formNhapHang_Load(object sender, EventArgs e)
        {
            dgvNhaphang.CellEndEdit += dgvNhaphang_CellEndEdit;
        }

        private void BtnCSP_Click(object sender, EventArgs e)
        {
            frmChonSanPham formcsp = new frmChonSanPham("NhapHang");
            formcsp.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvNhaphang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dgvNhaphang.SelectedRows[0];
                dgvNhaphang.Rows.Remove(selectedRow);
                CapNhatTongTien();  // Gọi hàm update tổng tiền

                MessageBox.Show("Đã xóa sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void themSanPham(string maSP)
        {
            //dgvNhaphang.Rows.Add(maSP);  // Gán giá trị vào các cột tương ứng
            var sanPham = db.DienThoais.SingleOrDefault(sp => sp.MaSP == maSP);
            string tenSP = sanPham != null ? sanPham.TenSP : "Không tìm thấy";

            double giaNhap = 0;

            var giaNhapQuery = db.ChiTietSanPham_IMEIs.Where(imei => imei.MaSP == maSP).Select(imei => imei.GiaNhap);
            if (giaNhapQuery.Any())
            {
                giaNhap = giaNhapQuery.Average();
            }

            int soLuongMacDinh = 1;
            double tong1sp = giaNhap * soLuongMacDinh;
            int rowIndex = dgvNhaphang.Rows.Add(maSP, tenSP, soLuongMacDinh, giaNhap.ToString("N0"), tong1sp);

            CapNhatTongTien();
        }

        private void dgvNhaphang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvNhaphang.Rows[e.RowIndex];

            // Nếu chỉnh sửa cột GiaNhap hoặc SoLuong, tính ThanhTien
            if (e.ColumnIndex == dgvNhaphang.Columns["GiaNhap"].Index || e.ColumnIndex == dgvNhaphang.Columns["SLNhap"].Index)
            {
                double giaNhap = 0;
                int soLuong = 0;

                // Lấy GiaNhap
                string giaNhapStr = row.Cells["GiaNhap"].Value?.ToString() ?? "0";
                double.TryParse(giaNhapStr.Replace(".", ""), out giaNhap); // Xử lý dấu phẩy trong định dạng N0

                // Lấy SoLuong
                string soLuongStr = row.Cells["SLNhap"].Value?.ToString() ?? "0";
                int.TryParse(soLuongStr, out soLuong);

                // Tính ThanhTien
                double tong1sp = giaNhap * soLuong;
                row.Cells["Tong"].Value = tong1sp.ToString("N0");

                // Cập nhật tổng tiền
                CapNhatTongTien();
            }
        }

        private void CapNhatTongTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvNhaphang.Rows)
            {
                if (!row.IsNewRow)
                {
                    string thanhTienStr = row.Cells["Tong"].Value?.ToString() ?? "0";
                    double tong1sp;
                    if (double.TryParse(thanhTienStr.Replace(".", ""), out tong1sp))
                    {
                        tongTien += tong1sp;
                    }
                }
            }
            Lbltongtien.Text = "Tổng tiền nhập" + "\n" + tongTien.ToString("N0") + " VND";
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhaphang.Rows.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm để lưu và in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lưu dữ liệu từ grid vào bảng NhapSanPham
                foreach (DataGridViewRow row in dgvNhaphang.Rows)
                {
                    if (row.IsNewRow) continue;

                    string maSP = row.Cells["MaSP"].Value?.ToString()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(maSP)) continue;

                    string tenSP = row.Cells["TenSP"].Value?.ToString()?.Trim() ?? "";
                    int slNhap = Convert.ToInt32(row.Cells["SLNhap"].Value ?? 0);
                    double gia = double.Parse(row.Cells["GiaNhap"].Value?.ToString()?.Replace(".", "") ?? "0");
                    double tongGia = double.Parse(row.Cells["Tong"].Value?.ToString()?.Replace(".", "") ?? "0");

                    // Tìm entity trong DB
                    var entity = db.NhapHangs.SingleOrDefault(n => n.MaSP == maSP);
                    if (entity == null)
                    {
                        // Insert mới
                        var nhap = new NhapHang
                        {
                            MaSP = maSP,
                            TenSP = tenSP,
                            SLNhap = slNhap,
                            Gia = (float)gia,
                            TongGia = (float)tongGia
                        };
                        db.NhapHangs.InsertOnSubmit(nhap);
                    }
                    else
                    {
                        // Update nếu tồn tại
                        entity.TenSP = tenSP;
                        entity.SLNhap = slNhap;
                        entity.Gia = (float)gia;
                        entity.TongGia = (float)tongGia;
                    }
                }

                db.SubmitChanges(); 
                MessageBox.Show("Đã xong, bấm OK để hiển thị phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmNhapHangPrinter form = new frmNhapHangPrinter();
                form.ShowDialog();

                // Clear grid sau lưu (tùy chọn)
                dgvNhaphang.Rows.Clear();
                CapNhatTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
