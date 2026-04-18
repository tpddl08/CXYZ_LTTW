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
    public partial class frmBanHang : Sunny.UI.UIForm
    {
        databaseDataContext db = new databaseDataContext();
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void BtnCSP_Click(object sender, EventArgs e)
        {
            frmChonSanPham formcsp = new frmChonSanPham("BanHang");
            formcsp.ShowDialog();
        }

        public void themSanPham(string imei, string tenSP, double gia)
        {
            // Thêm row mới vào DataGridView
            dgvSanpham.Rows.Add(imei, tenSP, gia);  // Gán giá trị vào các cột tương ứng

            // Tính và cập nhật tổng tiền
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvSanpham.Rows)
            {
                if (row.Cells["Gia"].Value != null && !row.IsNewRow)  // Kiểm tra để tránh lỗi nếu row rỗng
                {
                    tongTien += Convert.ToDouble(row.Cells["Gia"].Value);  // Cộng giá từ cột Gia
                }
            }
            Lbltongtien.Text = "Tổng tiền" + "\n" + tongTien.ToString("N0") + " VND";  // Hiển thị tổng tiền
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvSanpham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dgvSanpham.SelectedRows[0];
                string imei = selectedRow.Cells["IMEI"].Value.ToString();

                // Khôi phục IMEI về 'Trong kho'
                ChiTietSanPham_IMEI ct = db.ChiTietSanPham_IMEIs.SingleOrDefault(c => c.IMEI == imei);
                if (ct != null)
                {
                    ct.TinhTrang = "Trong kho";  // Khôi phục IMEI
                }

                // Tăng SoLuong sản phẩm lên 1
                string maSP = "";  // Lấy MaSP từ IMEI nếu cần (join DB)
                var product = from im in db.ChiTietSanPham_IMEIs
                              join dt2 in db.DienThoais on im.MaSP equals dt2.MaSP
                              where im.IMEI == imei
                              select dt2.MaSP;
                maSP = product.FirstOrDefault();
                DienThoai dt = db.DienThoais.SingleOrDefault(d => d.MaSP == maSP);
                if (dt != null)
                {
                    dt.SoLuong += 1;  // Tăng số lượng
                }

                db.SubmitChanges();  // Lưu thay đổi vào DB

                // Xóa row khỏi grid và cập nhật tổng tiền
                dgvSanpham.Rows.Remove(selectedRow);
                updateTongTien();  // Gọi hàm update tổng tiền

                MessageBox.Show("Đã xóa sản phẩm và khôi phục kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (dgvSanpham.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn hủy toàn bộ đơn hàng? (Sẽ khôi phục kho)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<string> imeiList = new List<string>();
                foreach (DataGridViewRow row in dgvSanpham.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string imei = row.Cells["IMEI"].Value.ToString();
                        imeiList.Add(imei);
                    }
                }

                // Khôi phục IMEI và tăng SoLuong cho tất cả
                foreach (string imei in imeiList)
                {
                    ChiTietSanPham_IMEI ct = db.ChiTietSanPham_IMEIs.SingleOrDefault(c => c.IMEI == imei);
                    if (ct != null)
                    {
                        ct.TinhTrang = "Trong kho";  // Khôi phục IMEI
                    }

                    // Tăng SoLuong sản phẩm
                    string maSP = "";  // Lấy MaSP từ IMEI
                    var product = from im in db.ChiTietSanPham_IMEIs
                                  join dt2 in db.DienThoais on im.MaSP equals dt2.MaSP
                                  where im.IMEI == imei
                                  select dt2.MaSP;
                    maSP = product.FirstOrDefault();
                    DienThoai dt = db.DienThoais.SingleOrDefault(d => d.MaSP == maSP);
                    if (dt != null)
                    {
                        dt.SoLuong += 1;  
                    }
                }

                db.SubmitChanges();  

                
                dgvSanpham.Rows.Clear();
                updateTongTien();  

                MessageBox.Show("Đã hủy đơn hàng và khôi phục kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void updateTongTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvSanpham.Rows)
            {
                if (row.Cells["Gia"].Value != null && !row.IsNewRow)
                {
                    tongTien += Convert.ToDouble(row.Cells["Gia"].Value);
                }
            }
            Lbltongtien.Text = "Tổng tiền" + "\n" + tongTien.ToString("N0") + " VND";
        }

        private void printhdBtn_Click(object sender, EventArgs e)
        {
            if (dgvSanpham.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenKH = TxtName.Text.Trim();
            string sdt = TxtSDT.Text.Trim();

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int maKH;
                KhachHang kh = db.KhachHangs.SingleOrDefault(k => k.SoDienThoai == sdt);

                if (kh == null)
                {
                    KhachHang newKh = new KhachHang
                    {
                        MaKH = (db.KhachHangs.Any() ? db.KhachHangs.Max(k => k.MaKH) : 0) + 1,
                        TenKH = tenKH,
                        SoDienThoai = sdt
                    };
                    db.KhachHangs.InsertOnSubmit(newKh);
                    db.SubmitChanges(); 
                    maKH = newKh.MaKH;
                }
                else 
                {
                    maKH = kh.MaKH;
                    if (kh.TenKH != tenKH)
                    {
                        kh.TenKH = tenKH;
                    }
                }

                double tongTien = 0;
                foreach (DataGridViewRow row in dgvSanpham.Rows)
                {
                    tongTien += Convert.ToDouble(row.Cells["Gia"].Value);
                }

                HoaDon newHoaDon = new HoaDon
                {
                    MaKH = maKH,
                    NgayLapHD = DateTime.Now,
                    TongTien = tongTien,
                };
                db.HoaDons.InsertOnSubmit(newHoaDon);
                db.SubmitChanges(); // Lưu để lấy MaHD tự tăng

                int maHDVuaTao = newHoaDon.MaHD;

                foreach (DataGridViewRow row in dgvSanpham.Rows)
                {
                    if (row.IsNewRow) continue; // bỏ hàng mới rỗng

                    // kiểm tra existence của cell "IMEI" và "Gia"
                    var imeiCell = row.Cells["IMEI"];
                    var giaCell = row.Cells["Gia"];

                    if (imeiCell == null || imeiCell.Value == null)
                    {
                        MessageBox.Show($"Dòng {row.Index + 1} thiếu IMEI. Vui lòng kiểm tra.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (giaCell == null || giaCell.Value == null)
                    {
                        MessageBox.Show($"Dòng {row.Index + 1} thiếu Giá. Vui lòng kiểm tra.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string imeiStr = imeiCell.Value.ToString();

                    double donGia;
                    // chuyển đổi giá an toàn
                    if (!double.TryParse(Convert.ToString(giaCell.Value), out donGia))
                    {
                        MessageBox.Show($"Giá không hợp lệ ở dòng {row.Index + 1}: '{giaCell.Value}'.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ChiTietHoaDon chiTiet = new ChiTietHoaDon
                    {
                        MaHD = maHDVuaTao,
                        IMEI = imeiStr,
                        DonGia = donGia
                    };
                    db.ChiTietHoaDons.InsertOnSubmit(chiTiet);
                }

                db.SubmitChanges();

                MessageBox.Show("Đã xong, bấm OK để hiển thị hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmHoaDonPrinter frm = new frmHoaDonPrinter();
                frm.ShowDialog();

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu hóa đơn: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHoaDonPrinter form = new frmHoaDonPrinter();
            form.ShowDialog();
            
        }

        private void ResetForm()
        {
            TxtName.Clear();
            TxtSDT.Clear();
            dgvSanpham.Rows.Clear();
            updateTongTien();
        }
    }
}
