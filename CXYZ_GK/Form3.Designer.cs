namespace CXYZ
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.retryBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.overPoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retryBtn
            // 
            this.retryBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retryBtn.BackColor = System.Drawing.SystemColors.Control;
            this.retryBtn.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.retryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retryBtn.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.retryBtn.Location = new System.Drawing.Point(141, 197);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Size = new System.Drawing.Size(421, 94);
            this.retryBtn.TabIndex = 0;
            this.retryBtn.Text = "Chơi lại";
            this.retryBtn.UseVisualStyleBackColor = false;
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBtn.BackColor = System.Drawing.SystemColors.Control;
            this.menuBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBtn.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.menuBtn.Location = new System.Drawing.Point(141, 297);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(421, 94);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.Text = "Quay lại menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.exitBtn.Location = new System.Drawing.Point(141, 397);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(421, 94);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Thoát game";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // overPoint
            // 
            this.overPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.overPoint.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overPoint.Location = new System.Drawing.Point(108, 33);
            this.overPoint.Name = "overPoint";
            this.overPoint.Size = new System.Drawing.Size(491, 142);
            this.overPoint.TabIndex = 3;
            this.overPoint.Text = "Thông báo";
            this.overPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(700, 518);
            this.Controls.Add(this.overPoint);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.retryBtn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird - CXYZ";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retryBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label overPoint;
    }
}