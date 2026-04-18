namespace CXYZ_CK
{
    partial class frmBaoHanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveBtn = new Sunny.UI.UIButton();
            this.deleteBtn = new Sunny.UI.UIButton();
            this.addBtn = new Sunny.UI.UIButton();
            this.closeBtn = new Sunny.UI.UIButton();
            this.dgvBaohanh = new Sunny.UI.UIDataGridView();
            this.searchTxtB = new Sunny.UI.UITextBox();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaohanh)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FillColor = System.Drawing.Color.DarkViolet;
            this.saveBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(674, 415);
            this.saveBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Radius = 10;
            this.saveBtn.Size = new System.Drawing.Size(143, 63);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveBtn.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Location = new System.Drawing.Point(80, 415);
            this.deleteBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Radius = 10;
            this.deleteBtn.Size = new System.Drawing.Size(142, 63);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deleteBtn.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FillColor = System.Drawing.Color.Green;
            this.addBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(275, 415);
            this.addBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Radius = 10;
            this.addBtn.Size = new System.Drawing.Size(143, 63);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Thêm";
            this.addBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addBtn.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FillColor = System.Drawing.Color.Blue;
            this.closeBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(490, 415);
            this.closeBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Radius = 10;
            this.closeBtn.Size = new System.Drawing.Size(142, 63);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.Text = "Thoát";
            this.closeBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dgvBaohanh
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvBaohanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvBaohanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaohanh.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBaohanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaohanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvBaohanh.ColumnHeadersHeight = 32;
            this.dgvBaohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBaohanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMEI,
            this.MaKH,
            this.NgayNhan,
            this.MoTaLoi,
            this.TinhTrangXuLy});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaohanh.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvBaohanh.EnableHeadersVisualStyles = false;
            this.dgvBaohanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvBaohanh.GridColor = System.Drawing.Color.Black;
            this.dgvBaohanh.Location = new System.Drawing.Point(80, 159);
            this.dgvBaohanh.Name = "dgvBaohanh";
            this.dgvBaohanh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaohanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvBaohanh.RowHeadersWidth = 62;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvBaohanh.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvBaohanh.RowTemplate.Height = 28;
            this.dgvBaohanh.ScrollBarColor = System.Drawing.Color.Black;
            this.dgvBaohanh.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvBaohanh.ScrollBarStyleInherited = false;
            this.dgvBaohanh.SelectedIndex = -1;
            this.dgvBaohanh.Size = new System.Drawing.Size(737, 236);
            this.dgvBaohanh.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvBaohanh.TabIndex = 12;
            // 
            // searchTxtB
            // 
            this.searchTxtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTxtB.Location = new System.Drawing.Point(80, 68);
            this.searchTxtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTxtB.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchTxtB.Name = "searchTxtB";
            this.searchTxtB.Padding = new System.Windows.Forms.Padding(5);
            this.searchTxtB.ShowText = false;
            this.searchTxtB.Size = new System.Drawing.Size(737, 51);
            this.searchTxtB.Symbol = 85;
            this.searchTxtB.SymbolColor = System.Drawing.Color.Black;
            this.searchTxtB.SymbolSize = 30;
            this.searchTxtB.TabIndex = 11;
            this.searchTxtB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchTxtB.Watermark = "";
            // 
            // IMEI
            // 
            this.IMEI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IMEI.DataPropertyName = "IMEI";
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Red;
            this.IMEI.DefaultCellStyle = dataGridViewCellStyle21;
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.MinimumWidth = 8;
            this.IMEI.Name = "IMEI";
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 100;
            this.MaKH.Name = "MaKH";
            // 
            // NgayNhan
            // 
            this.NgayNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhan.DataPropertyName = "NgayNhan";
            this.NgayNhan.HeaderText = "Ngày tiếp nhận";
            this.NgayNhan.MinimumWidth = 8;
            this.NgayNhan.Name = "NgayNhan";
            // 
            // MoTaLoi
            // 
            this.MoTaLoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTaLoi.DataPropertyName = "MoTaLoi";
            this.MoTaLoi.HeaderText = "Mô tả lỗi";
            this.MoTaLoi.MinimumWidth = 8;
            this.MoTaLoi.Name = "MoTaLoi";
            this.MoTaLoi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TinhTrangXuLy
            // 
            this.TinhTrangXuLy.DataPropertyName = "TinhTrangXuLy";
            this.TinhTrangXuLy.HeaderText = "Tình trạng xử lí";
            this.TinhTrangXuLy.MinimumWidth = 8;
            this.TinhTrangXuLy.Name = "TinhTrangXuLy";
            this.TinhTrangXuLy.Width = 150;
            // 
            // formBaoHanh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dgvBaohanh);
            this.Controls.Add(this.searchTxtB);
            this.Name = "formBaoHanh";
            this.Text = "Quản lí bảo hành";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.formBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaohanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton saveBtn;
        private Sunny.UI.UIButton deleteBtn;
        private Sunny.UI.UIButton addBtn;
        private Sunny.UI.UIButton closeBtn;
        private Sunny.UI.UIDataGridView dgvBaohanh;
        private Sunny.UI.UITextBox searchTxtB;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangXuLy;
    }
}