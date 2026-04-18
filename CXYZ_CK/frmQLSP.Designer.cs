namespace CXYZ_CK
{
    partial class frmQLSP
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
            this.saveBtn = new Sunny.UI.UIButton();
            this.deleteBtn = new Sunny.UI.UIButton();
            this.addBtn = new Sunny.UI.UIButton();
            this.closeBtn = new Sunny.UI.UIButton();
            this.dgvQLDienthoai = new Sunny.UI.UIDataGridView();
            this.quanLiDienThoaiDataSet1 = new CXYZ_CK.QuanLiDienThoaiDataSet1();
            this.hangSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangSanXuatTableAdapter = new CXYZ_CK.QuanLiDienThoaiDataSet1TableAdapters.HangSanXuatTableAdapter();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHSX = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDienthoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDienThoaiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FillColor = System.Drawing.Color.DarkViolet;
            this.saveBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(675, 386);
            this.saveBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Radius = 10;
            this.saveBtn.Size = new System.Drawing.Size(143, 63);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Location = new System.Drawing.Point(81, 386);
            this.deleteBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Radius = 10;
            this.deleteBtn.Size = new System.Drawing.Size(142, 63);
            this.deleteBtn.TabIndex = 14;
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
            this.addBtn.Location = new System.Drawing.Point(276, 386);
            this.addBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Radius = 10;
            this.addBtn.Size = new System.Drawing.Size(143, 63);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Thêm";
            this.addBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FillColor = System.Drawing.Color.Blue;
            this.closeBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(491, 386);
            this.closeBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Radius = 10;
            this.closeBtn.Size = new System.Drawing.Size(142, 63);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Text = "Thoát";
            this.closeBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dgvQLDienthoai
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvQLDienthoai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLDienthoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLDienthoai.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvQLDienthoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLDienthoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLDienthoai.ColumnHeadersHeight = 32;
            this.dgvQLDienthoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLDienthoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.TenHSX,
            this.SoLuong,
            this.Gia});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLDienthoai.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLDienthoai.EnableHeadersVisualStyles = false;
            this.dgvQLDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvQLDienthoai.GridColor = System.Drawing.Color.Black;
            this.dgvQLDienthoai.Location = new System.Drawing.Point(81, 118);
            this.dgvQLDienthoai.Name = "dgvQLDienthoai";
            this.dgvQLDienthoai.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLDienthoai.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQLDienthoai.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvQLDienthoai.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQLDienthoai.RowTemplate.Height = 28;
            this.dgvQLDienthoai.ScrollBarColor = System.Drawing.Color.Black;
            this.dgvQLDienthoai.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvQLDienthoai.ScrollBarStyleInherited = false;
            this.dgvQLDienthoai.SelectedIndex = -1;
            this.dgvQLDienthoai.Size = new System.Drawing.Size(737, 236);
            this.dgvQLDienthoai.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvQLDienthoai.TabIndex = 11;
            // 
            // quanLiDienThoaiDataSet1
            // 
            this.quanLiDienThoaiDataSet1.DataSetName = "QuanLiDienThoaiDataSet1";
            this.quanLiDienThoaiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangSanXuatBindingSource
            // 
            this.hangSanXuatBindingSource.DataMember = "HangSanXuat";
            this.hangSanXuatBindingSource.DataSource = this.quanLiDienThoaiDataSet1;
            // 
            // hangSanXuatTableAdapter
            // 
            this.hangSanXuatTableAdapter.ClearBeforeFill = true;
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
            // TenHSX
            // 
            this.TenHSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHSX.DataPropertyName = "TenHSX";
            this.TenHSX.DataSource = this.hangSanXuatBindingSource;
            this.TenHSX.DisplayMember = "TenHSX";
            this.TenHSX.HeaderText = "Hãng";
            this.TenHSX.MinimumWidth = 8;
            this.TenHSX.Name = "TenHSX";
            this.TenHSX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHSX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TenHSX.ValueMember = "MaHSX";
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
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            this.Gia.Width = 150;
            // 
            // formQLSP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dgvQLDienthoai);
            this.Name = "formQLSP";
            this.Text = "Quản lí sản phẩm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.formQLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDienthoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDienThoaiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton saveBtn;
        private Sunny.UI.UIButton deleteBtn;
        private Sunny.UI.UIButton addBtn;
        private Sunny.UI.UIButton closeBtn;
        private Sunny.UI.UIDataGridView dgvQLDienthoai;
        private QuanLiDienThoaiDataSet1 quanLiDienThoaiDataSet1;
        private System.Windows.Forms.BindingSource hangSanXuatBindingSource;
        private QuanLiDienThoaiDataSet1TableAdapters.HangSanXuatTableAdapter hangSanXuatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenHSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}