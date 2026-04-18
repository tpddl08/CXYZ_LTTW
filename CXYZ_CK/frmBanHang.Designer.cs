namespace CXYZ_CK
{
    partial class frmBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printhdBtn = new Sunny.UI.UIButton();
            this.deleteBtn = new Sunny.UI.UIButton();
            this.cancelBtn = new Sunny.UI.UIButton();
            this.TxtName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dgvSanpham = new Sunny.UI.UIDataGridView();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbltongtien = new Sunny.UI.UILabel();
            this.BtnCSP = new Sunny.UI.UISymbolButton();
            this.TxtSDT = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // printhdBtn
            // 
            this.printhdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printhdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printhdBtn.FillColor = System.Drawing.Color.DarkViolet;
            this.printhdBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.printhdBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.printhdBtn.Location = new System.Drawing.Point(656, 410);
            this.printhdBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.printhdBtn.Name = "printhdBtn";
            this.printhdBtn.Radius = 10;
            this.printhdBtn.Size = new System.Drawing.Size(189, 63);
            this.printhdBtn.TabIndex = 16;
            this.printhdBtn.Text = "In hóa đơn";
            this.printhdBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.printhdBtn.Click += new System.EventHandler(this.printhdBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Location = new System.Drawing.Point(491, 410);
            this.deleteBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Radius = 10;
            this.deleteBtn.Size = new System.Drawing.Size(142, 63);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FillColor = System.Drawing.Color.Blue;
            this.cancelBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.Location = new System.Drawing.Point(343, 410);
            this.cancelBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Radius = 10;
            this.cancelBtn.Size = new System.Drawing.Size(142, 63);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TxtName
            // 
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(277, 56);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtName.Name = "TxtName";
            this.TxtName.Padding = new System.Windows.Forms.Padding(5);
            this.TxtName.ShowText = false;
            this.TxtName.Size = new System.Drawing.Size(399, 37);
            this.TxtName.TabIndex = 18;
            this.TxtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtName.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(70, 56);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(200, 31);
            this.uiLabel1.TabIndex = 20;
            this.uiLabel1.Text = "Tên khách hàng";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(70, 98);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(169, 36);
            this.uiLabel2.TabIndex = 21;
            this.uiLabel2.Text = "Số điện thoại";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSanpham
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvSanpham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanpham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanpham.ColumnHeadersHeight = 32;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMEI,
            this.TenSP,
            this.Gia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanpham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanpham.EnableHeadersVisualStyles = false;
            this.dgvSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvSanpham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvSanpham.Location = new System.Drawing.Point(70, 175);
            this.dgvSanpham.Name = "dgvSanpham";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanpham.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSanpham.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvSanpham.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSanpham.RowTemplate.Height = 28;
            this.dgvSanpham.SelectedIndex = -1;
            this.dgvSanpham.Size = new System.Drawing.Size(775, 200);
            this.dgvSanpham.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvSanpham.TabIndex = 22;
            // 
            // IMEI
            // 
            this.IMEI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IMEI.DataPropertyName = "IMEI";
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.MinimumWidth = 8;
            this.IMEI.Name = "IMEI";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            // 
            // Lbltongtien
            // 
            this.Lbltongtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbltongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbltongtien.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Lbltongtien.Location = new System.Drawing.Point(70, 410);
            this.Lbltongtien.Name = "Lbltongtien";
            this.Lbltongtien.Size = new System.Drawing.Size(236, 63);
            this.Lbltongtien.TabIndex = 23;
            this.Lbltongtien.Text = "Tổng tiền\r\n";
            this.Lbltongtien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnCSP
            // 
            this.BtnCSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCSP.FillColor = System.Drawing.Color.Khaki;
            this.BtnCSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnCSP.Location = new System.Drawing.Point(725, 63);
            this.BtnCSP.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnCSP.Name = "BtnCSP";
            this.BtnCSP.Radius = 10;
            this.BtnCSP.Size = new System.Drawing.Size(120, 71);
            this.BtnCSP.Symbol = 162088;
            this.BtnCSP.SymbolColor = System.Drawing.Color.Black;
            this.BtnCSP.SymbolSize = 60;
            this.BtnCSP.TabIndex = 25;
            this.BtnCSP.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCSP.Click += new System.EventHandler(this.BtnCSP_Click);
            // 
            // TxtSDT
            // 
            this.TxtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSDT.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSDT.Location = new System.Drawing.Point(277, 103);
            this.TxtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSDT.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.Padding = new System.Windows.Forms.Padding(5);
            this.TxtSDT.ShowText = false;
            this.TxtSDT.Size = new System.Drawing.Size(399, 37);
            this.TxtSDT.TabIndex = 26;
            this.TxtSDT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtSDT.Watermark = "";
            // 
            // frmBanHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.Red;
            this.ControlBoxFillHoverColor = System.Drawing.Color.White;
            this.ControlBoxForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.TxtSDT);
            this.Controls.Add(this.BtnCSP);
            this.Controls.Add(this.Lbltongtien);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.printhdBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "frmBanHang";
            this.Text = "Bán sản phẩm";
            this.TitleColor = System.Drawing.Color.PowderBlue;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton printhdBtn;
        private Sunny.UI.UIButton deleteBtn;
        private Sunny.UI.UIButton cancelBtn;
        private Sunny.UI.UITextBox TxtName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDataGridView dgvSanpham;
        private Sunny.UI.UILabel Lbltongtien;
        private Sunny.UI.UISymbolButton BtnCSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private Sunny.UI.UITextBox TxtSDT;
    }
}