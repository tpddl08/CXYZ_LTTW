namespace CXYZ
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.BackColor = System.Drawing.Color.ForestGreen;
            this.scoreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreText.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Yellow;
            this.scoreText.Location = new System.Drawing.Point(3, 2);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(259, 62);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Điểm:";
            this.scoreText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeTop
            // 
            this.pipeTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::CXYZ.Properties.Resources.pipetop;
            this.pipeTop.Location = new System.Drawing.Point(775, 2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(127, 135);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 3;
            this.pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::CXYZ.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(273, 165);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(110, 89);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeBottom
            // 
            this.pipeBottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::CXYZ.Properties.Resources.pipebottom;
            this.pipeBottom.Location = new System.Drawing.Point(651, 291);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(131, 193);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = global::CXYZ.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 416);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(938, 68);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // food
            // 
            this.food.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.food.BackColor = System.Drawing.Color.Transparent;
            this.food.Image = global::CXYZ.Properties.Resources.apple;
            this.food.Location = new System.Drawing.Point(826, 164);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(100, 90);
            this.food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.food.TabIndex = 5;
            this.food.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::CXYZ.Properties.Resources.citybg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 484);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.food);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird - CXYZ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseisdown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox food;
    }
}

