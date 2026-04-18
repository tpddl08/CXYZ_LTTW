using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CXYZ_CK
{
    public partial class frmChangePW : Sunny.UI.UIForm
    {
        string taikhoan;
        public frmChangePW()
        {
            InitializeComponent();
        }
        public frmChangePW(string _taikhoan)
        {
            InitializeComponent();
            taikhoan = _taikhoan;
            TxtTaikhoan.Text = taikhoan; 
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            string tdn = TxtTaikhoan.Text;
            try
            {
                string matkhaumoi = TxtMatkhau.Text;
                string otpNhap = TxtOTP.Text;

                if (string.IsNullOrEmpty(matkhaumoi) || string.IsNullOrEmpty(otpNhap))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới và OTP!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                databaseDataContext db = new databaseDataContext();
                TaiKhoan nd = db.TaiKhoans.SingleOrDefault(p => p.TenDangNhap == tdn);
                if (nd == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nd.OTP == otpNhap)
                {
                    DateTime? otpDateSend = nd.OTPDateSend;
                    if (otpDateSend.HasValue && (DateTime.Now - otpDateSend.Value).TotalMinutes <= 10)
                    {
                        Random rd = new Random();
                        string randomKey = rd.Next(1000, 9999).ToString();

                        // Mã hóa mật khẩu mới (chỉ matkhaumoi, mkm + OTP)
                        MD5 md5 = MD5.Create();
                        byte[] inputBytes = Encoding.ASCII.GetBytes(matkhaumoi + randomKey);
                        byte[] hashBytes = md5.ComputeHash(inputBytes);

                        nd.MatKhau = hashBytes; 
                        nd.OTP = null; 
                        nd.OTPDateSend = null;
                        nd.RandomKey = randomKey; 

                        db.SubmitChanges();
                        MessageBox.Show("Đã đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Mã OTP hết hiệu lực. Vui lòng gửi lại OTP mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mã OTP không chính xác. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSendOTP_Click(object sender, EventArgs e)
        {
            string tdn = TxtTaikhoan.Text;
            try
            {
                databaseDataContext db = new databaseDataContext();
                TaiKhoan nd = db.TaiKhoans.SingleOrDefault(p => p.TenDangNhap == tdn);
                if (nd == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(nd.Email))
                {
                    MessageBox.Show("Tài khoản không có email đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Random rd = new Random();
                string otp = nd.OTP = rd.Next(1000, 9999).ToString();
                //nd.RandomKey = otp; 
                nd.OTPDateSend = DateTime.Now;

                SendMail.sendMailTo(nd.Email, "Mã OTP xác thực là: " + nd.OTP);

                db.SubmitChanges();
                MessageBox.Show("Đã gửi OTP qua email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}