using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace CXYZ_CK
{
    public partial class frmChonSanPham : Sunny.UI.UIForm
    {
        databaseDataContext db = new databaseDataContext();
        public string Caller { get; set; }
        public frmChonSanPham(string caller)
        {
            InitializeComponent();
            Caller = caller;
        }
        private void formChonSanPham_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            CbbHSX.DataSource = db.HangSanXuats.ToList();
            filterDienThoai();
        }
        private void filterDienThoai()
        {
            dgvDienthoai.AutoGenerateColumns = true;  
            string searchTerm = searchTxtB.Text.Trim().ToLower();
            string maHSX = CbbHSX.SelectedValue?.ToString() ?? ""; 
            // LINQ query join DienThoai với HangSanXuat để hiển thị TenHSX
            var query = from dt in db.DienThoais
                        join hsx in db.HangSanXuats on dt.MaHSX equals hsx.MaHSX
                        where (string.IsNullOrEmpty(maHSX) || dt.MaHSX == maHSX) && // Filter theo hãng nếu chọn
                              (string.IsNullOrEmpty(searchTerm) || dt.MaSP.ToLower().Contains(searchTerm) || dt.TenSP.ToLower().Contains(searchTerm)) // Filter theo MaSP hoặc TenSP
                        select new
                        {
                            MaSP = dt.MaSP,
                            TenSP = dt.TenSP,
                            SoLuong = dt.SoLuong,
                            Gia = dt.Gia
                        };
            dgvDienthoai.DataSource = query.ToList();
        }
        private void searchTxtB_TextChanged(object sender, EventArgs e)
        {
            filterDienThoai();
        }
        private void hsxCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDienThoai();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (dgvDienthoai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy MaSP từ row được chọn trên dgvDT (sửa lỗi bằng AutoGenerateColumns = true)
            string maSP = dgvDienthoai.SelectedRows[0].Cells["MaSP"].Value.ToString();

            if (Caller == "BanHang")
            {
                // LINQ query để lấy IMEI đầu tiên (FirstOrDefault) còn trong kho (TinhTrang = 'Trong kho') dựa trên MaSP
                var firstIMEI = from imei in db.ChiTietSanPham_IMEIs
                                join dt2 in db.DienThoais on imei.MaSP equals dt2.MaSP
                                where imei.MaSP == maSP && imei.TinhTrang == "Trong kho"  // Chỉ IMEI còn trong kho
                                select new
                                {
                                    IMEI = imei.IMEI,
                                    TenSP = dt2.TenSP,
                                    Gia = dt2.Gia
                                };

                var imeiObj = firstIMEI.FirstOrDefault();  // Lấy IMEI đầu tiên

                string imeiSelected = imeiObj.IMEI;
                string tenSP = imeiObj.TenSP;
                double gia = imeiObj.Gia;

                // Tìm IMEI trong DB và cập nhật TinhTrang = 'Da ban'
                ChiTietSanPham_IMEI ct = db.ChiTietSanPham_IMEIs.SingleOrDefault(c => c.IMEI == imeiSelected);
                if (ct != null)
                {
                    ct.TinhTrang = "Da ban"; // Xóa khỏi kho
                }
                else
                {
                    MessageBox.Show("IMEI không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tìm sản phẩm và giảm SoLuong đi 1
                DienThoai dt = db.DienThoais.SingleOrDefault(d => d.MaSP == ct.MaSP);
                if (dt != null && dt.SoLuong > 0)
                {
                    dt.SoLuong -= 1;
                }
                else
                {
                    MessageBox.Show("Sản phẩm hết hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.SubmitChanges(); // Lưu thay đổi vào DB

                // Gửi IMEI, TenSP, Gia đến formBanHang (giả sử formBanHang có method themSanPham)
                frmBanHang formbh = Application.OpenForms.OfType<frmBanHang>().FirstOrDefault(); // Tìm formBanHang đang mở
                if (formbh != null)
                {
                    formbh.themSanPham(imeiSelected, tenSP, gia); // Gọi method để thêm row vào DataGridView của formBanHang
                }
                else
                {
                    MessageBox.Show("Form bán hàng chưa mở!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh grid sản phẩm
                filterDienThoai();
            }

            else if (Caller == "NhapHang")
            {
                frmNhapHang formnh = Application.OpenForms.OfType<frmNhapHang>().FirstOrDefault();
                if (formnh != null)
                {
                    formnh.themSanPham(maSP); // Giả sử method themSanPham nhận MaSP, TenSP, Gia (không có IMEI)
                }
                else
                {
                    MessageBox.Show("Form nhập hàng chưa mở!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}