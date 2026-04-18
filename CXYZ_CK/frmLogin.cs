using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXYZ_CK
{
    public partial class frmLogin : Sunny.UI.UIForm
    {
        public static string name = "Vô danh";
        public string loggedInUserInfo { get; private set; }
        public string roleUser {  get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }
        private void infoTeam(object sender, EventArgs e)
        {
            using (frmTeamInfo in4 = new frmTeamInfo()){
                in4.ShowDialog();
            }
        }

        private void changePassword(object sender, EventArgs e)
        {
            using (frmChangePW changeP = new frmChangePW())
            {
                changeP.ShowDialog();
            }


        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = usernameTxt.Text;
            string pass = passwordTxt.Text;
            frmMain formMain = new frmMain();
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng điền thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                databaseDataContext db = new databaseDataContext();
                TaiKhoan tk = db.TaiKhoans.SingleOrDefault(p=>p.TenDangNhap == user);
                if(tk != null)
                {
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = Encoding.ASCII.GetBytes(pass + tk.RandomKey);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    if (tk.MatKhau == hashBytes)
                    {
                        if (tk.MaTaiKhoan == 1)
                        {
                            this.loggedInUserInfo = user;
                            name = user;
                            this.roleUser = "Admin";
                            MessageBox.Show("Xin chào " + loggedInUserInfo + "! - " + roleUser, "Thông báo", MessageBoxButtons.OK);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else if (tk.MaTaiKhoan == 2)
                        {
                            this.loggedInUserInfo = user;
                            name = user;
                            this.roleUser = "Quản lí";
                            MessageBox.Show("Xin chào " + loggedInUserInfo + "! - " + roleUser, "Thông báo", MessageBoxButtons.OK);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else if (tk.MaTaiKhoan == 3)
                        {
                            this.loggedInUserInfo = user;
                            name = user;
                            this.roleUser = "Thu ngân";
                            MessageBox.Show("Xin chào " + loggedInUserInfo + "! - " + roleUser, "Thông báo", MessageBoxButtons.OK);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTxt.Focus();
                }

            }
        }
    }
}
