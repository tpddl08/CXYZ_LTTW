namespace CXYZ_CK
{
    partial class frmQLTK
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTxtB = new Sunny.UI.UITextBox();
            this.dgvTaikhoan = new Sunny.UI.UIDataGridView();
            this.loaiTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiDienThoaiDataSet = new CXYZ_CK.QuanLiDienThoaiDataSet();
            this.closeBtn = new Sunny.UI.UIButton();
            this.deleteBtn = new Sunny.UI.UIButton();
            this.addBtn = new Sunny.UI.UIButton();
            this.saveBtn = new Sunny.UI.UIButton();
            this.loaiTaiKhoanTableAdapter = new CXYZ_CK.QuanLiDienThoaiDataSetTableAdapters.LoaiTaiKhoanTableAdapter();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDienThoaiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxtB
            // 
            this.searchTxtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTxtB.Location = new System.Drawing.Point(82, 67);
            this.searchTxtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTxtB.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchTxtB.Name = "searchTxtB";
            this.searchTxtB.Padding = new System.Windows.Forms.Padding(5);
            this.searchTxtB.ShowText = false;
            this.searchTxtB.Size = new System.Drawing.Size(737, 51);
            this.searchTxtB.Symbol = 85;
            this.searchTxtB.SymbolColor = System.Drawing.Color.Black;
            this.searchTxtB.SymbolSize = 30;
            this.searchTxtB.TabIndex = 0;
            this.searchTxtB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchTxtB.Watermark = "";
            this.searchTxtB.TextChanged += new System.EventHandler(this.searchTxtB_TextChanged);
            // 
            // dgvTaikhoan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvTaikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaikhoan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTaikhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaikhoan.ColumnHeadersHeight = 32;
            this.dgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.MatKhau,
            this.Email,
            this.LoaiTaiKhoan});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaikhoan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTaikhoan.EnableHeadersVisualStyles = false;
            this.dgvTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvTaikhoan.GridColor = System.Drawing.Color.Black;
            this.dgvTaikhoan.Location = new System.Drawing.Point(82, 146);
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaikhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTaikhoan.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvTaikhoan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTaikhoan.RowTemplate.Height = 28;
            this.dgvTaikhoan.ScrollBarColor = System.Drawing.Color.Black;
            this.dgvTaikhoan.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTaikhoan.ScrollBarStyleInherited = false;
            this.dgvTaikhoan.SelectedIndex = -1;
            this.dgvTaikhoan.Size = new System.Drawing.Size(737, 236);
            this.dgvTaikhoan.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvTaikhoan.TabIndex = 1;
            // 
            // loaiTaiKhoanBindingSource
            // 
            this.loaiTaiKhoanBindingSource.DataMember = "LoaiTaiKhoan";
            this.loaiTaiKhoanBindingSource.DataSource = this.quanLiDienThoaiDataSet;
            // 
            // quanLiDienThoaiDataSet
            // 
            this.quanLiDienThoaiDataSet.DataSetName = "QuanLiDienThoaiDataSet";
            this.quanLiDienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FillColor = System.Drawing.Color.Blue;
            this.closeBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(492, 414);
            this.closeBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Radius = 10;
            this.closeBtn.Size = new System.Drawing.Size(142, 63);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Thoát";
            this.closeBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Location = new System.Drawing.Point(82, 414);
            this.deleteBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Radius = 10;
            this.deleteBtn.Size = new System.Drawing.Size(142, 63);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FillColor = System.Drawing.Color.Green;
            this.addBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(277, 414);
            this.addBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Radius = 10;
            this.addBtn.Size = new System.Drawing.Size(143, 63);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Thêm";
            this.addBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FillColor = System.Drawing.Color.DarkViolet;
            this.saveBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(676, 414);
            this.saveBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Radius = 10;
            this.saveBtn.Size = new System.Drawing.Size(143, 63);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loaiTaiKhoanTableAdapter
            // 
            this.loaiTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            this.TenDangNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenDangNhap.HeaderText = "MSNV";
            this.TenDangNhap.MinimumWidth = 8;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 131;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu (đã mã hóa)";
            this.MatKhau.MinimumWidth = 8;
            this.MatKhau.Name = "MatKhau";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.LoaiTaiKhoan.DataSource = this.loaiTaiKhoanBindingSource;
            this.LoaiTaiKhoan.DisplayMember = "TenLoaiTaiKhoan";
            this.LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.LoaiTaiKhoan.MinimumWidth = 8;
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiTaiKhoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LoaiTaiKhoan.ValueMember = "MaTaiKhoan";
            this.LoaiTaiKhoan.Width = 131;
            // 
            // formQLTK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.Red;
            this.ControlBoxFillHoverColor = System.Drawing.Color.White;
            this.ControlBoxForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dgvTaikhoan);
            this.Controls.Add(this.searchTxtB);
            this.Name = "formQLTK";
            this.RectColor = System.Drawing.Color.Transparent;
            this.Text = "Quản lí các tài khoản";
            this.TitleColor = System.Drawing.Color.PowderBlue;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.formQLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDienThoaiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox searchTxtB;
        private Sunny.UI.UIDataGridView dgvTaikhoan;
        private Sunny.UI.UIButton closeBtn;
        private Sunny.UI.UIButton deleteBtn;
        private Sunny.UI.UIButton addBtn;
        private Sunny.UI.UIButton saveBtn;
        private QuanLiDienThoaiDataSet quanLiDienThoaiDataSet;
        private System.Windows.Forms.BindingSource loaiTaiKhoanBindingSource;
        private QuanLiDienThoaiDataSetTableAdapters.LoaiTaiKhoanTableAdapter loaiTaiKhoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoaiTaiKhoan;
    }
}