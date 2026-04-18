namespace CXYZ_CK
{
    partial class frmBCTK
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
            this.CbbHSX = new Sunny.UI.UIComboBox();
            this.dgvDienthoai = new Sunny.UI.UIDataGridView();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbltongtien = new Sunny.UI.UILabel();
            this.BtnPrint = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienthoai)).BeginInit();
            this.SuspendLayout();
            // 
            // CbbHSX
            // 
            this.CbbHSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbbHSX.DataSource = null;
            this.CbbHSX.DisplayMember = "TenHSX";
            this.CbbHSX.FillColor = System.Drawing.Color.White;
            this.CbbHSX.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbHSX.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.CbbHSX.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CbbHSX.Location = new System.Drawing.Point(676, 57);
            this.CbbHSX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbHSX.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbbHSX.Name = "CbbHSX";
            this.CbbHSX.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CbbHSX.Size = new System.Drawing.Size(143, 63);
            this.CbbHSX.SymbolSize = 24;
            this.CbbHSX.TabIndex = 13;
            this.CbbHSX.Text = "Hãng";
            this.CbbHSX.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbbHSX.ValueMember = "MaHSX";
            this.CbbHSX.Watermark = "";
            this.CbbHSX.SelectedIndexChanged += new System.EventHandler(this.CbbHSX_SelectedIndexChanged);
            // 
            // dgvDienthoai
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvDienthoai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDienthoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDienthoai.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDienthoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDienthoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDienthoai.ColumnHeadersHeight = 32;
            this.dgvDienthoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDienthoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMEI,
            this.TenSP,
            this.NgayLapHD,
            this.Gia});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDienthoai.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDienthoai.EnableHeadersVisualStyles = false;
            this.dgvDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvDienthoai.GridColor = System.Drawing.Color.Black;
            this.dgvDienthoai.Location = new System.Drawing.Point(82, 141);
            this.dgvDienthoai.Name = "dgvDienthoai";
            this.dgvDienthoai.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDienthoai.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDienthoai.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvDienthoai.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDienthoai.RowTemplate.Height = 28;
            this.dgvDienthoai.ScrollBarColor = System.Drawing.Color.Black;
            this.dgvDienthoai.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDienthoai.ScrollBarStyleInherited = false;
            this.dgvDienthoai.SelectedIndex = -1;
            this.dgvDienthoai.Size = new System.Drawing.Size(737, 258);
            this.dgvDienthoai.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvDienthoai.TabIndex = 12;
            // 
            // IMEI
            // 
            this.IMEI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IMEI.DataPropertyName = "IMEI";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            this.IMEI.DefaultCellStyle = dataGridViewCellStyle3;
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.MinimumWidth = 8;
            this.IMEI.Name = "IMEI";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 100;
            this.TenSP.Name = "TenSP";
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Thời gian bán";
            this.NgayLapHD.MinimumWidth = 8;
            this.NgayLapHD.Name = "NgayLapHD";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá bán";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            // 
            // Lbltongtien
            // 
            this.Lbltongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbltongtien.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Lbltongtien.Location = new System.Drawing.Point(82, 57);
            this.Lbltongtien.Name = "Lbltongtien";
            this.Lbltongtien.Size = new System.Drawing.Size(236, 63);
            this.Lbltongtien.TabIndex = 24;
            this.Lbltongtien.Text = "Tổng doanh thu\r\n";
            this.Lbltongtien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.FillColor = System.Drawing.Color.Purple;
            this.BtnPrint.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Location = new System.Drawing.Point(597, 420);
            this.BtnPrint.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Radius = 10;
            this.BtnPrint.Size = new System.Drawing.Size(222, 64);
            this.BtnPrint.TabIndex = 25;
            this.BtnPrint.Text = "In doanh thu";
            this.BtnPrint.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // frmBCTK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.Lbltongtien);
            this.Controls.Add(this.CbbHSX);
            this.Controls.Add(this.dgvDienthoai);
            this.Name = "frmBCTK";
            this.Text = "Báo cáo thống kê";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.frmBCTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienthoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox CbbHSX;
        private Sunny.UI.UIDataGridView dgvDienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private Sunny.UI.UILabel Lbltongtien;
        private Sunny.UI.UIButton BtnPrint;
    }
}