using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny;

namespace CXYZ_CK
{
    public partial class frmMain : Sunny.UI.UIForm
    {

        string infod = "Bạn chưa đăng nhập";
        string roleUser = "Người xem";
        bool isLogin = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void formmain_Load(object sender, EventArgs e)
        {
            UpdateUIBasedOnLoginStatus();

        }


        private void UpdateUIBasedOnLoginStatus()
        {
            infoLb.Text = "Xin chào " + infod + "! - " + roleUser;
            

            if (isLogin == true)
            {
                // Trạng thái đã đăng nhập
                logBtn.Text = "Đăng xuất";
                logBtn.FillColor = Color.Red;
            }
            else
            {
                // Trạng thái chưa đăng nhập
                logBtn.Text = "Đăng nhập";
                logBtn.FillColor = Color.Green;
            }

            string user = infod;
            databaseDataContext db = new databaseDataContext();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(p => p.TenDangNhap == user);

            qltkBtn.Enabled = bhBtn.Enabled = qlBtn.Enabled = bctkBtn.Enabled = false;
            if (isLogin && tk.MaTaiKhoan == 1)
            {
                qltkBtn.Enabled = bhBtn.Enabled = qlBtn.Enabled = bctkBtn.Enabled = true;
            }
            else if (isLogin && tk.MaTaiKhoan == 2)
            {
                bhBtn.Enabled = qlBtn.Enabled = true;
            }
            else if (isLogin && tk.MaTaiKhoan == 3)
            {
                bhBtn.Enabled = true;
            }
        }

        private void teamBtn_Click(object sender, EventArgs e)
        {
            using (frmTeamInfo in4 = new frmTeamInfo())
            {
                in4.ShowDialog();
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {

            if (isLogin == true)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isLogin = false;
                    infod = "Bạn chưa đăng nhập";
                    roleUser = "Người xem";
                    UpdateUIBasedOnLoginStatus();
                }
            }
            else
            {
                frmLogin formlogin = new frmLogin();
                if (formlogin.ShowDialog() == DialogResult.OK)
                {
                    isLogin = true;
                    infod = formlogin.loggedInUserInfo;
                    roleUser = formlogin.roleUser;
                    UpdateUIBasedOnLoginStatus();
                }
            }
        }

        private void qltkBtn_Click(object sender, EventArgs e)
        {
            frmQLTK formqltk = new frmQLTK();
            formqltk.ShowDialog();
        }

        private void bhBtn_Click(object sender, EventArgs e)
        {
            frmBanHang formbh = new frmBanHang();
            formbh.ShowDialog();
        }

        private void qlBtn_Click(object sender, EventArgs e)
        {   
            frmQLChung formqlc = new frmQLChung();
            formqlc.ShowDialog();
        }

        private void bctkBtn_Click(object sender, EventArgs e)
        {
            frmBCTK formbctk = new frmBCTK();
            formbctk.ShowDialog();
        }

        private void BtnChangePW_Click(object sender, EventArgs e)
        {
            using (frmChangePW changeP = new frmChangePW())
            {
                changeP.ShowDialog();
            }
        }
    }
}
