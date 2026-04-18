namespace CXYZ_CK
{
    partial class frmNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnPrint = new Sunny.UI.UIButton();
            this.deleteBtn = new Sunny.UI.UIButton();
            this.dgvNhaphang = new Sunny.UI.UIDataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbltongtien = new Sunny.UI.UILabel();
            this.BtnCSP = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.FillColor = System.Drawing.Color.DarkViolet;
            this.BtnPrint.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPrint.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.BtnPrint.Location = new System.Drawing.Point(593, 420);
            this.BtnPrint.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Radius = 10;
            this.BtnPrint.Size = new System.Drawing.Size(239, 63);
            this.BtnPrint.TabIndex = 16;
            this.BtnPrint.Text = "In phiếu nhập";
            this.BtnPrint.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Location = new System.Drawing.Point(405, 420);
            this.deleteBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Radius = 10;
            this.deleteBtn.Size = new System.Drawing.Size(142, 63);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dgvNhaphang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNhaphang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhaphang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhaphang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhaphang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhaphang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhaphang.ColumnHeadersHeight = 32;
            this.dgvNhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SLNhap,
            this.GiaNhap,
            this.Tong});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhaphang.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhaphang.EnableHeadersVisualStyles = false;
            this.dgvNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvNhaphang.GridColor = System.Drawing.Color.Black;
            this.dgvNhaphang.Location = new System.Drawing.Point(82, 149);
            this.dgvNhaphang.Name = "dgvNhaphang";
            this.dgvNhaphang.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhaphang.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhaphang.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvNhaphang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhaphang.RowTemplate.Height = 28;
            this.dgvNhaphang.ScrollBarColor = System.Drawing.Color.Black;
            this.dgvNhaphang.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvNhaphang.ScrollBarStyleInherited = false;
            this.dgvNhaphang.SelectedIndex = -1;
            this.dgvNhaphang.Size = new System.Drawing.Size(750, 236);
            this.dgvNhaphang.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNhaphang.TabIndex = 12;
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.DataPropertyName = "MaSP";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            this.MaSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 100;
            this.TenSP.Name = "TenSP";
            // 
            // SLNhap
            // 
            this.SLNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SLNhap.DataPropertyName = "SLNhap";
            this.SLNhap.HeaderText = "SL nhập";
            this.SLNhap.MinimumWidth = 8;
            this.SLNhap.Name = "SLNhap";
            // 
            // GiaNhap
            // 
            this.GiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập/1SP";
            this.GiaNhap.MinimumWidth = 8;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Tong
            // 
            this.Tong.DataPropertyName = "Tong";
            this.Tong.HeaderText = "Tổng";
            this.Tong.MinimumWidth = 8;
            this.Tong.Name = "Tong";
            this.Tong.Width = 150;
            // 
            // Lbltongtien
            // 
            this.Lbltongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbltongtien.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Lbltongtien.Location = new System.Drawing.Point(82, 64);
            this.Lbltongtien.Name = "Lbltongtien";
            this.Lbltongtien.Size = new System.Drawing.Size(236, 63);
            this.Lbltongtien.TabIndex = 24;
            this.Lbltongtien.Text = "Tổng tiền\r\n";
            this.Lbltongtien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnCSP
            // 
            this.BtnCSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCSP.FillColor = System.Drawing.Color.Khaki;
            this.BtnCSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnCSP.Location = new System.Drawing.Point(732, 50);
            this.BtnCSP.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnCSP.Name = "BtnCSP";
            this.BtnCSP.Radius = 10;
            this.BtnCSP.Size = new System.Drawing.Size(100, 77);
            this.BtnCSP.Symbol = 62088;
            this.BtnCSP.SymbolColor = System.Drawing.Color.Black;
            this.BtnCSP.SymbolSize = 70;
            this.BtnCSP.TabIndex = 25;
            this.BtnCSP.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCSP.Click += new System.EventHandler(this.BtnCSP_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.BtnCSP);
            this.Controls.Add(this.Lbltongtien);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dgvNhaphang);
            this.Name = "frmNhapHang";
            this.Text = "Nhập hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.formNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaphang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton BtnPrint;
        private Sunny.UI.UIButton deleteBtn;
        private Sunny.UI.UIDataGridView dgvNhaphang;
        private Sunny.UI.UILabel Lbltongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private Sunny.UI.UISymbolButton BtnCSP;
    }
}