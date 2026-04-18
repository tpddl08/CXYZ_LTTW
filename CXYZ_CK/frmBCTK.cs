using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CXYZ_CK
{
    public partial class frmBCTK : Sunny.UI.UIForm
    {
        databaseDataContext db = new databaseDataContext();
        public static string tenhsx = "Tất cả";

        public frmBCTK()
        {
            InitializeComponent();
        }

        private void frmBCTK_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            LoadThongKe();
        }

        private void loadDuLieu()
        {
            var hsxList = db.HangSanXuats
                            .Select(h => new { h.MaHSX, h.TenHSX })
                            .ToList();

            var ds = new List<object>();
            ds.Add(new { MaHSX = "", TenHSX = "Tất cả" });
            ds.AddRange(hsxList);

            CbbHSX.DisplayMember = "TenHSX";
            CbbHSX.ValueMember = "MaHSX";
            CbbHSX.DataSource = ds;
        }

        private void CbbHSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            try
            {
                string maHSX = CbbHSX.SelectedValue?.ToString() ?? "";

                var query =
                    from cthd in db.ChiTietHoaDons
                    join hd in db.HoaDons on cthd.MaHD equals hd.MaHD
                    join imei in db.ChiTietSanPham_IMEIs on cthd.IMEI equals imei.IMEI
                    join dt in db.DienThoais on imei.MaSP equals dt.MaSP
                    where imei.TinhTrang != null
                          && imei.TinhTrang.Trim().ToLower() == "da ban"
                          && (maHSX == "" || dt.MaHSX == maHSX)
                    orderby hd.NgayLapHD
                    select new
                    {
                        IMEI = imei.IMEI,
                        TenSP = dt.TenSP,
                        NgayLapHD = hd.NgayLapHD,
                        Gia = cthd.DonGia
                    };

                var list = query.ToList();
                dgvDienthoai.DataSource = list;

                double total = list.Sum(x => (double?)x.Gia) ?? 0;
                Lbltongtien.Text = "Tổng doanh thu\n" + total.ToString("N0") + " VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDienthoai.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để lưu.");
                    return;
                }

                tenhsx = CbbHSX.Text;
                // Lấy dữ liệu từ DataGridView
                var rows = new List<DoanhThu>();

                foreach (DataGridViewRow r in dgvDienthoai.Rows)
                {
                    if (r.IsNewRow) continue;

                    string imei = r.Cells["IMEI"].Value?.ToString();
                    string ten = r.Cells["TenSP"].Value?.ToString();
                    DateTime? ngay = r.Cells["NgayLapHD"].Value as DateTime?;
                    double gia = Convert.ToDouble(r.Cells["Gia"].Value);

                    rows.Add(new DoanhThu
                    {
                        IMEI = imei,
                        TenSP = ten,
                        NgayLapHD = ngay,
                        Gia = gia
                    });
                }

                // Xoá những bản ghi trùng IMEI
                var imeiList = rows.Select(x => x.IMEI).ToList();

                var toDelete = db.DoanhThus
                                 .Where(d => imeiList.Contains(d.IMEI))
                                 .ToList();

                db.DoanhThus.DeleteAllOnSubmit(toDelete);

                // Thêm dữ liệu mới
                db.DoanhThus.InsertAllOnSubmit(rows);

                db.SubmitChanges();

                MessageBox.Show("Đã xong, bấm nút OK để xem bản in!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmDoanhThuPrinter from = new frmDoanhThuPrinter();
                from.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu DoanhThu: " + ex.Message);
            }
        }
    }
}
