namespace CXYZ
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.playerLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeChartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerLb
            // 
            this.playerLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerLb.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLb.FormattingEnabled = true;
            this.playerLb.ItemHeight = 29;
            this.playerLb.Location = new System.Drawing.Point(52, 103);
            this.playerLb.Name = "playerLb";
            this.playerLb.Size = new System.Drawing.Size(901, 379);
            this.playerLb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(289, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng xếp hạng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeChartBtn
            // 
            this.closeChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeChartBtn.BackColor = System.Drawing.Color.Red;
            this.closeChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeChartBtn.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeChartBtn.ForeColor = System.Drawing.Color.Black;
            this.closeChartBtn.Location = new System.Drawing.Point(905, 0);
            this.closeChartBtn.Name = "closeChartBtn";
            this.closeChartBtn.Size = new System.Drawing.Size(112, 47);
            this.closeChartBtn.TabIndex = 2;
            this.closeChartBtn.Text = "Đóng";
            this.closeChartBtn.UseVisualStyleBackColor = false;
            this.closeChartBtn.Click += new System.EventHandler(this.closeChartBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1012, 511);
            this.Controls.Add(this.closeChartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird - CXYZ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox playerLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeChartBtn;
    }
}