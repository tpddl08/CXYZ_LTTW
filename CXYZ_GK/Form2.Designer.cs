namespace CXYZ
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuL = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.chartBtn = new System.Windows.Forms.Button();
            this.soundBtn = new System.Windows.Forms.Button();
            this.SWBtn = new System.Windows.Forms.Button();
            this.FBtn = new System.Windows.Forms.Button();
            this.FDBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuL
            // 
            this.menuL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuL.BackColor = System.Drawing.Color.Transparent;
            this.menuL.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold);
            this.menuL.ForeColor = System.Drawing.Color.Black;
            this.menuL.Location = new System.Drawing.Point(48, 19);
            this.menuL.Name = "menuL";
            this.menuL.Size = new System.Drawing.Size(103, 55);
            this.menuL.TabIndex = 5;
            this.menuL.Text = "Tên";
            this.menuL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerNameBox
            // 
            this.playerNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerNameBox.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameBox.Location = new System.Drawing.Point(157, 24);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(477, 55);
            this.playerNameBox.TabIndex = 100;
            this.playerNameBox.Tag = "";
            // 
            // chartBtn
            // 
            this.chartBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartBtn.BackgroundImage = global::CXYZ.Properties.Resources.chart;
            this.chartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartBtn.Location = new System.Drawing.Point(740, 19);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(72, 60);
            this.chartBtn.TabIndex = 102;
            this.chartBtn.UseVisualStyleBackColor = true;
            this.chartBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // soundBtn
            // 
            this.soundBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soundBtn.BackgroundImage = global::CXYZ.Properties.Resources.soundon;
            this.soundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soundBtn.Location = new System.Drawing.Point(830, 19);
            this.soundBtn.Name = "soundBtn";
            this.soundBtn.Size = new System.Drawing.Size(64, 60);
            this.soundBtn.TabIndex = 101;
            this.soundBtn.UseVisualStyleBackColor = true;
            this.soundBtn.Click += new System.EventHandler(this.soundStatusClick);
            // 
            // SWBtn
            // 
            this.SWBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SWBtn.BackColor = System.Drawing.Color.Lime;
            this.SWBtn.BackgroundImage = global::CXYZ.Properties.Resources.snowbg;
            this.SWBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SWBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SWBtn.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWBtn.ForeColor = System.Drawing.Color.White;
            this.SWBtn.Location = new System.Drawing.Point(494, 292);
            this.SWBtn.Name = "SWBtn";
            this.SWBtn.Size = new System.Drawing.Size(400, 180);
            this.SWBtn.TabIndex = 9;
            this.SWBtn.Text = "Tuyết trắng";
            this.SWBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SWBtn.UseVisualStyleBackColor = false;
            this.SWBtn.Click += new System.EventHandler(this.SWBtnClick);
            // 
            // FBtn
            // 
            this.FBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBtn.BackColor = System.Drawing.Color.Lime;
            this.FBtn.BackgroundImage = global::CXYZ.Properties.Resources.flamebg;
            this.FBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FBtn.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBtn.ForeColor = System.Drawing.Color.White;
            this.FBtn.Location = new System.Drawing.Point(48, 292);
            this.FBtn.Name = "FBtn";
            this.FBtn.Size = new System.Drawing.Size(400, 180);
            this.FBtn.TabIndex = 8;
            this.FBtn.Text = "Núi lửa";
            this.FBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FBtn.UseVisualStyleBackColor = false;
            this.FBtn.Click += new System.EventHandler(this.FBtnClick);
            // 
            // FDBtn
            // 
            this.FDBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FDBtn.BackColor = System.Drawing.Color.Lime;
            this.FDBtn.BackgroundImage = global::CXYZ.Properties.Resources.forestbg;
            this.FDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FDBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FDBtn.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDBtn.ForeColor = System.Drawing.Color.White;
            this.FDBtn.Location = new System.Drawing.Point(494, 97);
            this.FDBtn.Name = "FDBtn";
            this.FDBtn.Size = new System.Drawing.Size(400, 180);
            this.FDBtn.TabIndex = 7;
            this.FDBtn.Text = "Rừng tối";
            this.FDBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FDBtn.UseVisualStyleBackColor = false;
            this.FDBtn.Click += new System.EventHandler(this.FDBtnClick);
            // 
            // CBtn
            // 
            this.CBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBtn.BackColor = System.Drawing.Color.Lime;
            this.CBtn.BackgroundImage = global::CXYZ.Properties.Resources.citybg;
            this.CBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CBtn.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtn.ForeColor = System.Drawing.Color.White;
            this.CBtn.Location = new System.Drawing.Point(48, 97);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(400, 180);
            this.CBtn.TabIndex = 6;
            this.CBtn.Text = "Thành phố";
            this.CBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBtn.UseVisualStyleBackColor = false;
            this.CBtn.Click += new System.EventHandler(this.CBtnClick);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(938, 484);
            this.Controls.Add(this.chartBtn);
            this.Controls.Add(this.soundBtn);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.SWBtn);
            this.Controls.Add(this.FBtn);
            this.Controls.Add(this.FDBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.menuL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "Form2";
            this.Text = "Flappy Bird - CXYZ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snowBtn;
        private System.Windows.Forms.Button flameBtn;
        private System.Windows.Forms.Button forestBtn;
        private System.Windows.Forms.Button cityBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label menuL;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button FDBtn;
        private System.Windows.Forms.Button FBtn;
        private System.Windows.Forms.Button SWBtn;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.Button soundBtn;
        private System.Windows.Forms.Button chartBtn;
    }
}