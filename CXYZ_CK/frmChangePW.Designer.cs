namespace CXYZ_CK
{
    partial class frmChangePW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtOTP = new Sunny.UI.UITextBox();
            this.TxtMatkhau = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.submitBtn = new Sunny.UI.UIButton();
            this.closeBtn = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.TxtTaikhoan = new Sunny.UI.UITextBox();
            this.BtnSendOTP = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // TxtOTP
            // 
            this.TxtOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtOTP.Location = new System.Drawing.Point(80, 226);
            this.TxtOTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOTP.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtOTP.Name = "TxtOTP";
            this.TxtOTP.Padding = new System.Windows.Forms.Padding(5);
            this.TxtOTP.Radius = 10;
            this.TxtOTP.ShowText = false;
            this.TxtOTP.Size = new System.Drawing.Size(735, 59);
            this.TxtOTP.Symbol = 558130;
            this.TxtOTP.SymbolColor = System.Drawing.Color.Black;
            this.TxtOTP.SymbolSize = 30;
            this.TxtOTP.TabIndex = 2;
            this.TxtOTP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtOTP.Watermark = "";
            // 
            // TxtMatkhau
            // 
            this.TxtMatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtMatkhau.Location = new System.Drawing.Point(80, 336);
            this.TxtMatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMatkhau.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtMatkhau.Name = "TxtMatkhau";
            this.TxtMatkhau.Padding = new System.Windows.Forms.Padding(5);
            this.TxtMatkhau.Radius = 10;
            this.TxtMatkhau.ShowText = false;
            this.TxtMatkhau.Size = new System.Drawing.Size(735, 59);
            this.TxtMatkhau.Symbol = 559196;
            this.TxtMatkhau.SymbolColor = System.Drawing.Color.Black;
            this.TxtMatkhau.SymbolSize = 40;
            this.TxtMatkhau.TabIndex = 3;
            this.TxtMatkhau.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtMatkhau.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(80, 179);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(604, 42);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "Nhập mã OTP gồm 4 số được gửi đến email";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(80, 295);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(315, 36);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "Nhập mật khẩu mới";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.FillColor = System.Drawing.Color.Green;
            this.submitBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(652, 414);
            this.submitBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Radius = 10;
            this.submitBtn.RectColor = System.Drawing.Color.Black;
            this.submitBtn.Size = new System.Drawing.Size(163, 64);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Hoàn tất";
            this.submitBtn.TipsFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FillColor = System.Drawing.Color.Red;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(440, 414);
            this.closeBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Radius = 10;
            this.closeBtn.RectColor = System.Drawing.Color.Black;
            this.closeBtn.Size = new System.Drawing.Size(163, 64);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Hủy bỏ";
            this.closeBtn.TipsFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(80, 56);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(235, 42);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "Nhập MSNV";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtTaikhoan
            // 
            this.TxtTaikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtTaikhoan.Location = new System.Drawing.Point(80, 103);
            this.TxtTaikhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTaikhoan.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtTaikhoan.Name = "TxtTaikhoan";
            this.TxtTaikhoan.Padding = new System.Windows.Forms.Padding(5);
            this.TxtTaikhoan.Radius = 10;
            this.TxtTaikhoan.ShowText = false;
            this.TxtTaikhoan.Size = new System.Drawing.Size(604, 59);
            this.TxtTaikhoan.Symbol = 62141;
            this.TxtTaikhoan.SymbolColor = System.Drawing.Color.Black;
            this.TxtTaikhoan.SymbolSize = 30;
            this.TxtTaikhoan.TabIndex = 0;
            this.TxtTaikhoan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtTaikhoan.Watermark = "";
            // 
            // BtnSendOTP
            // 
            this.BtnSendOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSendOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSendOTP.FillColor = System.Drawing.Color.Yellow;
            this.BtnSendOTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendOTP.ForeColor = System.Drawing.Color.Black;
            this.BtnSendOTP.Location = new System.Drawing.Point(691, 103);
            this.BtnSendOTP.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnSendOTP.Name = "BtnSendOTP";
            this.BtnSendOTP.Radius = 10;
            this.BtnSendOTP.Size = new System.Drawing.Size(124, 60);
            this.BtnSendOTP.TabIndex = 1;
            this.BtnSendOTP.Text = "Gửi OTP";
            this.BtnSendOTP.TipsFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendOTP.TipsForeColor = System.Drawing.Color.Black;
            this.BtnSendOTP.Click += new System.EventHandler(this.BtnSendOTP_Click);
            // 
            // frmChangePW
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBoxFillHoverColor = System.Drawing.Color.White;
            this.ControlBoxForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.BtnSendOTP);
            this.Controls.Add(this.TxtTaikhoan);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.TxtMatkhau);
            this.Controls.Add(this.TxtOTP);
            this.Name = "frmChangePW";
            this.RectColor = System.Drawing.Color.Transparent;
            this.Text = "Thay đổi mật khẩu";
            this.TitleColor = System.Drawing.Color.PowderBlue;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox TxtOTP;
        private Sunny.UI.UITextBox TxtMatkhau;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton submitBtn;
        private Sunny.UI.UIButton closeBtn;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox TxtTaikhoan;
        private Sunny.UI.UIButton BtnSendOTP;
    }
}