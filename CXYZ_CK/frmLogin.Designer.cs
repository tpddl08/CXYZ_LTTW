namespace CXYZ_CK
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.usernameTxt = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.passwordTxt = new Sunny.UI.UITextBox();
            this.uiUserControl1 = new Sunny.UI.UIUserControl();
            this.closeBtn = new Sunny.UI.UIButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.loginBtn = new Sunny.UI.UIButton();
            this.uiUserControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            resources.ApplyResources(this.usernameTxt, "usernameTxt");
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Radius = 10;
            this.usernameTxt.ShowText = false;
            this.usernameTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameTxt.Watermark = "";
            // 
            // uiLabel1
            // 
            resources.ApplyResources(this.uiLabel1, "uiLabel1");
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Name = "uiLabel1";
            // 
            // passwordTxt
            // 
            resources.ApplyResources(this.passwordTxt, "passwordTxt");
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Radius = 10;
            this.passwordTxt.ShowText = false;
            this.passwordTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordTxt.Watermark = "";
            // 
            // uiUserControl1
            // 
            resources.ApplyResources(this.uiUserControl1, "uiUserControl1");
            this.uiUserControl1.Controls.Add(this.closeBtn);
            this.uiUserControl1.Controls.Add(this.uiSymbolLabel2);
            this.uiUserControl1.Controls.Add(this.uiSymbolLabel1);
            this.uiUserControl1.Controls.Add(this.uiLinkLabel1);
            this.uiUserControl1.Controls.Add(this.passwordTxt);
            this.uiUserControl1.Controls.Add(this.loginBtn);
            this.uiUserControl1.Controls.Add(this.usernameTxt);
            this.uiUserControl1.Name = "uiUserControl1";
            this.uiUserControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FillColor = System.Drawing.Color.Red;
            this.closeBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Radius = 10;
            this.closeBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // uiSymbolLabel2
            // 
            resources.ApplyResources(this.uiSymbolLabel2, "uiSymbolLabel2");
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Symbol = 61475;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.SymbolSize = 30;
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            resources.ApplyResources(this.uiSymbolLabel1, "uiSymbolLabel1");
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Symbol = 62141;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 30;
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.uiLinkLabel1, "uiLinkLabel1");
            this.uiLinkLabel1.BackColor = System.Drawing.Color.White;
            this.uiLinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.Click += new System.EventHandler(this.changePassword);
            // 
            // loginBtn
            // 
            resources.ApplyResources(this.loginBtn, "loginBtn");
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FillColor = System.Drawing.Color.Green;
            this.loginBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Radius = 10;
            this.loginBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // formLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleGreen;
            resources.ApplyResources(this, "$this");
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.Red;
            this.ControlBoxFillHoverColor = System.Drawing.Color.White;
            this.ControlBoxForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiUserControl1);
            this.Name = "formLogin";
            this.RectColor = System.Drawing.Color.Transparent;
            this.TitleColor = System.Drawing.Color.PowderBlue;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.uiUserControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox usernameTxt;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox passwordTxt;
        private Sunny.UI.UIUserControl uiUserControl1;
        private Sunny.UI.UIButton loginBtn;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIButton closeBtn;
    }
}