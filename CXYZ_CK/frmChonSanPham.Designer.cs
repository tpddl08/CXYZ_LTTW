namespace CXYZ_CK
{
    partial class frmChonSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDienthoai = new Sunny.UI.UIDataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTxtB = new Sunny.UI.UITextBox();
            this.addBtn = new Sunny.UI.UIButton();
            this.CbbHSX = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienthoai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDienthoai
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvDienthoai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDienthoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDienthoai.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDienthoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDienthoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDienthoai.ColumnHeadersHeight = 32;
            this.dgvDienthoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDienthoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Gia,
            this.SoLuong});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDienthoai.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDienthoai.EnableHeadersVisualStyles = false;
            this.dgvDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvDienthoai.GridColor = System.Drawing.Color.Black;
            this.dgvDienthoai.Location = new System.Drawing.Point(82, 144);
            this.dgvDienthoai.Name = "dgvDienthoai";
            this.dgvDienthoai.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDienthoai.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDienthoai.RowHeadersWidth = 62;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvDienthoai.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDienthoai.RowTemplate.Height = 28;
            this.dgvDienthoai.ScrollBarColor = System.Drawing.Color.Black;
            this.dgvDienthoai.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDienthoai.ScrollBarStyleInherited = false;
            this.dgvDienthoai.SelectedIndex = -1;
            this.dgvDienthoai.Size = new System.Drawing.Size(737, 258);
            this.dgvDienthoai.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvDienthoai.TabIndex = 3;
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.DataPropertyName = "MaSP";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Red;
            this.MaSP.DefaultCellStyle = dataGridViewCellStyle15;
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 100;
            this.TenSP.Name = "TenSP";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá bán";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // searchTxtB
            // 
            this.searchTxtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtB.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtB.Location = new System.Drawing.Point(82, 73);
            this.searchTxtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTxtB.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchTxtB.Name = "searchTxtB";
            this.searchTxtB.Padding = new System.Windows.Forms.Padding(5);
            this.searchTxtB.ShowText = false;
            this.searchTxtB.Size = new System.Drawing.Size(491, 47);
            this.searchTxtB.Symbol = 85;
            this.searchTxtB.SymbolColor = System.Drawing.Color.Black;
            this.searchTxtB.SymbolSize = 30;
            this.searchTxtB.TabIndex = 2;
            this.searchTxtB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchTxtB.Watermark = "";
            this.searchTxtB.TextChanged += new System.EventHandler(this.searchTxtB_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FillColor = System.Drawing.Color.Green;
            this.addBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(676, 423);
            this.addBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Radius = 10;
            this.addBtn.Size = new System.Drawing.Size(143, 63);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Thêm";
            this.addBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.CbbHSX.Location = new System.Drawing.Point(676, 73);
            this.CbbHSX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbHSX.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbbHSX.Name = "CbbHSX";
            this.CbbHSX.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CbbHSX.Size = new System.Drawing.Size(143, 47);
            this.CbbHSX.SymbolSize = 24;
            this.CbbHSX.TabIndex = 10;
            this.CbbHSX.Text = "Hãng";
            this.CbbHSX.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbbHSX.ValueMember = "MaHSX";
            this.CbbHSX.Watermark = "";
            this.CbbHSX.SelectedIndexChanged += new System.EventHandler(this.hsxCbb_SelectedIndexChanged);
            // 
            // formChonSanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.Red;
            this.ControlBoxFillHoverColor = System.Drawing.Color.White;
            this.ControlBoxForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.CbbHSX);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dgvDienthoai);
            this.Controls.Add(this.searchTxtB);
            this.Name = "formChonSanPham";
            this.Text = "Danh sách sản phẩm";
            this.TitleColor = System.Drawing.Color.PowderBlue;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.formChonSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienthoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvDienthoai;
        private Sunny.UI.UITextBox searchTxtB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private Sunny.UI.UIButton addBtn;
        private Sunny.UI.UIComboBox CbbHSX;
    }
}