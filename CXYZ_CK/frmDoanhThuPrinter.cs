using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Sunny;
namespace CXYZ_CK
{
    public partial class frmDoanhThuPrinter : Sunny.UI.UIForm
    {
        public frmDoanhThuPrinter()
        {
            InitializeComponent();
        }

        private void frmDoanhthuPrinter_Load(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            var dbdoanhthu = db.DoanhThus.OrderBy(p => p.IMEI).ToList();
            double tong = dbdoanhthu.Sum(n => (double?)(n.Gia) ?? 0.0);

            ReportParameter[] para = new ReportParameter[3];
            para[0] = new ReportParameter("nguoidung", frmLogin.name);
            para[1] = new ReportParameter("tongdoanhthu", tong.ToString("N0", CultureInfo.CurrentCulture));
            para[2] = new ReportParameter("tenhsx", frmBCTK.tenhsx);

            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Clear();

            var rds = new ReportDataSource("DataSetDoanhThu", dbdoanhthu);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();

            var all = db.DoanhThus.ToList();
            if (all.Any())
            {
                db.DoanhThus.DeleteAllOnSubmit(all);
                db.SubmitChanges();
            }
        }
    }
}
