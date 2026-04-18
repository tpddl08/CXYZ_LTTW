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
using Sunny;
using System.Globalization;

namespace CXYZ_CK
{
    public partial class frmNhapHangPrinter : Sunny.UI.UIForm
    {
        public frmNhapHangPrinter()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            var allNhapHang = db.NhapHangs.OrderBy(p => p.MaSP).ToList();
            double tong = allNhapHang.Sum(n => (double?)(n.TongGia) ?? 0.0);

            ReportParameter[] para = new ReportParameter[2];
            para[0] = new ReportParameter("nguoidung", frmLogin.name);
            para[1] = new ReportParameter("tonggianhap", tong.ToString("N0", CultureInfo.CurrentCulture));

            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Clear();

            var rds = new ReportDataSource("DataSetNhapHang", allNhapHang);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();

            var all = db.NhapHangs.ToList();
            if (all.Any())
            {
                db.NhapHangs.DeleteAllOnSubmit(all);
                db.SubmitChanges();
            }
        }
    }
}
