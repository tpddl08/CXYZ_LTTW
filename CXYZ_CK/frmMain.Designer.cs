namespace CXYZ_CK
{
    partial class frmMain
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
            this.uiNavBar2 = new Sunny.UI.UINavBar();
            this.BtnChangePW = new Sunny.UI.UISymbolButton();
            this.infoLb = new Sunny.UI.UILabel();
            this.teamBtn = new Sunny.UI.UISymbolButton();
            this.logBtn = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.qltkBtn = new Sunny.UI.UIButton();
            this.bctkBtn = new Sunny.UI.UIButton();
            this.bhBtn = new Sunny.UI.UIButton();
            this.qlBtn = new Sunny.UI.UIButton();
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiNavBar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiNavBar2
            // 
            this.uiNavBar2.BackColor = System.Drawing.Color.SteelBlue;
            this.uiNavBar2.Controls.Add(this.BtnChangePW);
            this.uiNavBar2.Controls.Add(this.infoLb);
            this.uiNavBar2.Controls.Add(this.teamBtn);
            this.uiNavBar2.Controls.Add(this.logBtn);
            this.uiNavBar2.Controls.Add(this.uiLabel1);
            this.uiNavBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiNavBar2.DropMenuFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiNavBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiNavBar2.Location = new System.Drawing.Point(0, 35);
            this.uiNavBar2.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavBar2.Name = "uiNavBar2";
            this.uiNavBar2.Size = new System.Drawing.Size(900, 157);
            this.uiNavBar2.TabIndex = 1;
            this.uiNavBar2.Text = "uiNavBar2";
            // 
            // BtnChangePW
            // 
            this.BtnChangePW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangePW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnChangePW.Location = new System.Drawing.Point(551, 88);
            this.BtnChangePW.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnChangePW.Name = "BtnChangePW";
            this.BtnChangePW.Radius = 10;
            this.BtnChangePW.Size = new System.Drawing.Size(74, 50);
            this.BtnChangePW.Symbol = 361572;
            this.BtnChangePW.SymbolColor = System.Drawing.Color.Black;
            this.BtnChangePW.SymbolSize = 40;
            this.BtnChangePW.TabIndex = 6;
            this.BtnChangePW.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnChangePW.Click += new System.EventHandler(this.BtnChangePW_Click);
            // 
            // infoLb
            // 
            this.infoLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLb.ForeColor = System.Drawing.Color.Black;
            this.infoLb.Location = new System.Drawing.Point(37, 90);
            this.infoLb.Name = "infoLb";
            this.infoLb.Size = new System.Drawing.Size(489, 50);
            this.infoLb.TabIndex = 1;
            this.infoLb.Text = "Chào, [Tên] - [Vai trò]";
            this.infoLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamBtn
            // 
            this.teamBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.teamBtn.Location = new System.Drawing.Point(631, 88);
            this.teamBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.teamBtn.Name = "teamBtn";
            this.teamBtn.Radius = 10;
            this.teamBtn.Size = new System.Drawing.Size(71, 52);
            this.teamBtn.Symbol = 61632;
            this.teamBtn.SymbolColor = System.Drawing.Color.Black;
            this.teamBtn.SymbolSize = 50;
            this.teamBtn.TabIndex = 3;
            this.teamBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.teamBtn.Click += new System.EventHandler(this.teamBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.logBtn.FillColor2 = System.Drawing.Color.Red;
            this.logBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.Location = new System.Drawing.Point(708, 88);
            this.logBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.logBtn.Name = "logBtn";
            this.logBtn.Radius = 10;
            this.logBtn.RectColor = System.Drawing.Color.Black;
            this.logBtn.Size = new System.Drawing.Size(175, 52);
            this.logBtn.TabIndex = 2;
            this.logBtn.Text = "Đăng nhập";
            this.logBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(25, 12);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(858, 68);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI CXYZ";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qltkBtn
            // 
            this.qltkBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.qltkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qltkBtn.FillColor = System.Drawing.Color.Coral;
            this.qltkBtn.FillDisableColor = System.Drawing.Color.Silver;
            this.qltkBtn.FillHoverColor = System.Drawing.Color.Navy;
            this.qltkBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qltkBtn.ForeColor = System.Drawing.Color.Black;
            this.qltkBtn.Location = new System.Drawing.Point(33, 215);
            this.qltkBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.qltkBtn.Name = "qltkBtn";
            this.qltkBtn.Radius = 10;
            this.qltkBtn.RectColor = System.Drawing.Color.Gray;
            this.qltkBtn.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.qltkBtn.Size = new System.Drawing.Size(229, 51);
            this.qltkBtn.TabIndex = 0;
            this.qltkBtn.Text = "Quyền truy cập";
            this.qltkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qltkBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qltkBtn.Click += new System.EventHandler(this.qltkBtn_Click);
            // 
            // bctkBtn
            // 
            this.bctkBtn.BackColor = System.Drawing.Color.Bisque;
            this.bctkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bctkBtn.FillColor = System.Drawing.Color.Coral;
            this.bctkBtn.FillDisableColor = System.Drawing.Color.Silver;
            this.bctkBtn.FillHoverColor = System.Drawing.Color.Navy;
            this.bctkBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bctkBtn.ForeColor = System.Drawing.Color.Black;
            this.bctkBtn.Location = new System.Drawing.Point(33, 431);
            this.bctkBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.bctkBtn.Name = "bctkBtn";
            this.bctkBtn.Radius = 10;
            this.bctkBtn.RectColor = System.Drawing.Color.Gray;
            this.bctkBtn.Size = new System.Drawing.Size(160, 51);
            this.bctkBtn.TabIndex = 3;
            this.bctkBtn.Text = "Thống kê";
            this.bctkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bctkBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bctkBtn.Click += new System.EventHandler(this.bctkBtn_Click);
            // 
            // bhBtn
            // 
            this.bhBtn.BackColor = System.Drawing.Color.Bisque;
            this.bhBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bhBtn.FillColor = System.Drawing.Color.Coral;
            this.bhBtn.FillDisableColor = System.Drawing.Color.Silver;
            this.bhBtn.FillHoverColor = System.Drawing.Color.Navy;
            this.bhBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhBtn.ForeColor = System.Drawing.Color.Black;
            this.bhBtn.Location = new System.Drawing.Point(33, 281);
            this.bhBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.bhBtn.Name = "bhBtn";
            this.bhBtn.Radius = 10;
            this.bhBtn.RectColor = System.Drawing.Color.Gray;
            this.bhBtn.Size = new System.Drawing.Size(181, 51);
            this.bhBtn.TabIndex = 1;
            this.bhBtn.Text = "Bán hàng";
            this.bhBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bhBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhBtn.Click += new System.EventHandler(this.bhBtn_Click);
            // 
            // qlBtn
            // 
            this.qlBtn.BackColor = System.Drawing.Color.Bisque;
            this.qlBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qlBtn.FillColor = System.Drawing.Color.Coral;
            this.qlBtn.FillDisableColor = System.Drawing.Color.Silver;
            this.qlBtn.FillHoverColor = System.Drawing.Color.Navy;
            this.qlBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlBtn.ForeColor = System.Drawing.Color.Black;
            this.qlBtn.Location = new System.Drawing.Point(33, 356);
            this.qlBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.qlBtn.Name = "qlBtn";
            this.qlBtn.Radius = 10;
            this.qlBtn.RectColor = System.Drawing.Color.Gray;
            this.qlBtn.Size = new System.Drawing.Size(166, 51);
            this.qlBtn.TabIndex = 2;
            this.qlBtn.Text = "Quản lí";
            this.qlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qlBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlBtn.Click += new System.EventHandler(this.qlBtn_Click);
            // 
            // uiNavMenu1
            // 
            this.uiNavMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiNavMenu1.BackColor = System.Drawing.Color.SkyBlue;
            this.uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiNavMenu1.FullRowSelect = true;
            this.uiNavMenu1.HotTracking = true;
            this.uiNavMenu1.ItemHeight = 50;
            this.uiNavMenu1.Location = new System.Drawing.Point(0, 188);
            this.uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavMenu1.Name = "uiNavMenu1";
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.ShowPlusMinus = false;
            this.uiNavMenu1.ShowRootLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(308, 321);
            this.uiNavMenu1.TabIndex = 4;
            this.uiNavMenu1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(359, 281);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(514, 207);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "- Thu ngân có quyền truy cập Bán hàng\r\n- Quản lí bao gồm quyền truy cập của thu n" +
    "gân và Quản lí, Thống kê\r\n- Admin có tất cả các quyền\r\n\r\n";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(353, 214);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(71, 52);
            this.uiSymbolLabel1.Symbol = 61530;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 50;
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.Red;
            this.ControlBoxFillHoverColor = System.Drawing.Color.White;
            this.ControlBoxForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiNavBar2);
            this.Controls.Add(this.bctkBtn);
            this.Controls.Add(this.bhBtn);
            this.Controls.Add(this.qlBtn);
            this.Controls.Add(this.qltkBtn);
            this.Controls.Add(this.uiNavMenu1);
            this.Controls.Add(this.uiLabel2);
            this.Name = "formMain";
            this.RectColor = System.Drawing.Color.Transparent;
            this.Text = "Trang chủ";
            this.TitleColor = System.Drawing.Color.PowderBlue;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.formmain_Load);
            this.uiNavBar2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UINavBar uiNavBar2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel infoLb;
        private Sunny.UI.UIButton logBtn;
        private Sunny.UI.UISymbolButton teamBtn;
        private Sunny.UI.UIButton bctkBtn;
        private Sunny.UI.UIButton qlBtn;
        private Sunny.UI.UIButton qltkBtn;
        private Sunny.UI.UIButton bhBtn;
        private Sunny.UI.UINavMenu uiNavMenu1;
        private Sunny.UI.UISymbolButton BtnChangePW;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}