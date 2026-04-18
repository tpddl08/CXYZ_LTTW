using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CXYZ_CK
{
    public partial class frmHoaDonPrinter : Sunny.UI.UIForm
    {
        public frmHoaDonPrinter()
        {
            InitializeComponent();
        }

        private void frmHoaDonPrinter_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[1];
            para[0] = new ReportParameter("nguoidung", frmLogin.name);

            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Clear();

            databaseDataContext db = new databaseDataContext();
            var newestOrder = db.HoaDons.OrderByDescending(p => p.MaHD).FirstOrDefault();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetHoaDon",
                new[] { newestOrder }));

            var newestOrder2 = db.KhachHangs.FirstOrDefault(p => p.MaKH == newestOrder.MaKH);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKhachHang",
                new[] { newestOrder2 }));

            var newestOrder3 = db.ChiTietHoaDons.FirstOrDefault(p => p.MaHD == newestOrder.MaHD);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetChiTietHoaDon",
               new[] { newestOrder3 }));

            this.reportViewer1.RefreshReport();
        }
    }
}
