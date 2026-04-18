namespace CXYZ_CK
{
    partial class frmQLChung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNhaphang = new Sunny.UI.UIButton();
            this.btnQLSP = new Sunny.UI.UIButton();
            this.btnQLBH = new Sunny.UI.UIButton();
            this.dgvHangsanxuat = new Sunny.UI.UIDataGridView();
            this.MaHSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoaiVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new Sunny.UI.UIButton();
            this.btnXoa = new Sunny.UI.UIButton();
            this.btnThem = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangsanxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhaphang.BackColor = System.Drawing.Color.Orange;
            this.btnNhaphang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhaphang.FillColor = System.Drawing.Color.Transparent;
            this.btnNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaphang.ForeColor = System.Drawing.Color.Black;
            this.btnNhaphang.Location = new System.Drawing.Point(24, 57);
            this.btnNhaphang.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Radius = 10;
            this.btnNhaphang.RectColor = System.Drawing.Color.Gray;
            this.btnNhaphang.Size = new System.Drawing.Size(144, 49);
            this.btnNhaphang.TabIndex = 0;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaphang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLSP.BackColor = System.Drawing.Color.Orange;
            this.btnQLSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLSP.FillColor = System.Drawing.Color.Transparent;
            this.btnQLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSP.ForeColor = System.Drawing.Color.Black;
            this.btnQLSP.Location = new System.Drawing.Point(191, 57);
            this.btnQLSP.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Radius = 10;
            this.btnQLSP.RectColor = System.Drawing.Color.Gray;
            this.btnQLSP.Size = new System.Drawing.Size(225, 49);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "Quản lí sản phẩm";
            this.btnQLSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSP.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnQLBH
            // 
            this.btnQLBH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLBH.BackColor = System.Drawing.Color.Orange;
            this.btnQLBH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLBH.FillColor = System.Drawing.Color.Transparent;
            this.btnQLBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBH.ForeColor = System.Drawing.Color.Black;
            this.btnQLBH.Location = new System.Drawing.Point(450, 57);
            this.btnQLBH.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQLBH.Name = "btnQLBH";
            this.btnQLBH.Radius = 10;
            this.btnQLBH.RectColor = System.Drawing.Color.Gray;
            this.btnQLBH.Size = new System.Drawing.Size(225, 49);
            this.btnQLBH.TabIndex = 2;
            this.btnQLBH.Text = "Quản lí bảo hành";
            this.btnQLBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLBH.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnQLBH.Click += new System.EventHandler(this.btnQLBH_Click);
            // 
            // dgvHangsanxuat
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvHangsanxuat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvHangsanxuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvHangsanxuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangsanxuat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangsanxuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvHangsanxuat.ColumnHeadersHeight = 32;
            this.dgvHangsanxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHangsanxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHSX,
            this.TenHSX,
            this.DiaChiVN,
            this.SoDienThoaiVN});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangsanxuat.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvHangsanxuat.EnableHeadersVisualStyles = false;
            this.dgvHangsanxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvHangsanxuat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvHangsanxuat.Location = new System.Drawing.Point(24, 134);
            this.dgvHangsanxuat.Name = "dgvHangsanxuat";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangsanxuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvHangsanxuat.RowHeadersWidth = 62;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvHangsanxuat.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvHangsanxuat.RowTemplate.Height = 28;
            this.dgvHangsanxuat.SelectedIndex = -1;
            this.dgvHangsanxuat.Size = new System.Drawing.Size(684, 335);
            this.dgvHangsanxuat.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvHangsanxuat.TabIndex = 3;
            // 
            // MaHSX
            // 
            this.MaHSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHSX.DataPropertyName = "MaHSX";
            this.MaHSX.HeaderText = "Mã HSX";
            this.MaHSX.MinimumWidth = 8;
            this.MaHSX.Name = "MaHSX";
            // 
            // TenHSX
            // 
            this.TenHSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHSX.DataPropertyName = "TenHSX";
            this.TenHSX.HeaderText = "Tên HSX";
            this.TenHSX.MinimumWidth = 8;
            this.TenHSX.Name = "TenHSX";
            // 
            // DiaChiVN
            // 
            this.DiaChiVN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChiVN.DataPropertyName = "DiaChiVN";
            this.DiaChiVN.HeaderText = "Địa chỉ";
            this.DiaChiVN.MinimumWidth = 8;
            this.DiaChiVN.Name = "DiaChiVN";
            // 
            // SoDienThoaiVN
            // 
            this.SoDienThoaiVN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDienThoaiVN.DataPropertyName = "SoDienThoaiVN";
            this.SoDienThoaiVN.HeaderText = "Số điện thoại";
            this.SoDienThoaiVN.MinimumWidth = 8;
            this.SoDienThoaiVN.Name = "SoDienThoaiVN";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FillColor = System.Drawing.Color.DarkViolet;
            this.btnLuu.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(737, 352);
            this.btnLuu.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Radius = 10;
            this.btnLuu.Size = new System.Drawing.Size(143, 63);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.Red;
            this.btnXoa.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(738, 248);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Radius = 10;
            this.btnXoa.Size = new System.Drawing.Size(142, 63);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.Green;
            this.btnThem.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(737, 134);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Radius = 10;
            this.btnThem.Size = new System.Drawing.Size(143, 63);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // formQLChung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.Red;
            this.ControlBoxFillHoverColor = System.Drawing.Color.White;
            this.ControlBoxForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHangsanxuat);
            this.Controls.Add(this.btnQLBH);
            this.Controls.Add(this.btnQLSP);
            this.Controls.Add(this.btnNhaphang);
            this.Name = "formQLChung";
            this.Text = "Quản lý";
            this.TitleColor = System.Drawing.Color.PowderBlue;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.formQLChung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangsanxuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btnNhaphang;
        private Sunny.UI.UIButton btnQLSP;
        private Sunny.UI.UIButton btnQLBH;
        private Sunny.UI.UIDataGridView dgvHangsanxuat;
        private Sunny.UI.UIButton btnLuu;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UIButton btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoaiVN;
    }
}