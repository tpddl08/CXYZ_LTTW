namespace CXYZ
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.guideL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guideL
            // 
            this.guideL.BackColor = System.Drawing.Color.Linen;
            this.guideL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guideL.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideL.ForeColor = System.Drawing.Color.Black;
            this.guideL.Location = new System.Drawing.Point(43, 39);
            this.guideL.Name = "guideL";
            this.guideL.Size = new System.Drawing.Size(1033, 330);
            this.guideL.TabIndex = 0;
            this.guideL.Text = "Hướng dẫn\r\nQua ống cộng 1 điểm, ăn thức ăn cộng 2 điểm\r\nDùng phím cách hoặc phím " +
    "mũi tên lên để cho chim bay lên\r\nNhấn một trong hai phím trên để bắt đầu!";
            this.guideL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1123, 413);
            this.Controls.Add(this.guideL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird - CXYZ";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.closeGuideNoti);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label guideL;
    }
}