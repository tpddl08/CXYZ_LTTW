using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CXYZ
{

    public partial class Form2 : Form
    {
        private bool soundCheck = true;

        public bool soundStatus
        {
            get { return soundCheck; }
        }

        public Form2()
        {
            InitializeComponent();
            UpdateSoundButtonAppearance();
        }
        private void charBtn_Click(object sender, EventArgs e)
        {
            using (Form4 scoreBoard = new Form4())
            { 
                scoreBoard.ShowDialog(); 
            }
        }
        public GameTheme SelectedTheme 
        {
            get; 
            private set; 
        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == CBtn)
            {
                SelectedTheme = GameTheme.City;
            }
            else if (clickedButton == FDBtn)
            {
                SelectedTheme = GameTheme.ForestDark;
            }
            else if (clickedButton == FBtn)
            {
                SelectedTheme = GameTheme.Flame;
            }
            else if (clickedButton == SWBtn)
            {
                SelectedTheme = GameTheme.SnowWhite;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CBtnClick(object sender, EventArgs e)
        {
            ThemeButton_Click(sender, e);
        }

        private void FDBtnClick(object sender, EventArgs e)
        {
            ThemeButton_Click(sender, e);
        }

        private void FBtnClick(object sender, EventArgs e)
        {
            ThemeButton_Click(sender, e);
        }

        private void SWBtnClick(object sender, EventArgs e)
        {
            ThemeButton_Click(sender, e);
        }

        public string playerName
        {
            get
            {
                if (!string.IsNullOrEmpty(playerNameBox.Text.Trim()))
                {
                    return playerNameBox.Text;
                }
                else
                {
                    return "Vô danh";
                }
            }
        }

        private void UpdateSoundButtonAppearance()
        {
            if (soundCheck)
            {
                soundBtn.BackgroundImage = Properties.Resources.soundon;
            }
            else
            {
                soundBtn.BackgroundImage = Properties.Resources.soundoff;
            }
        }

        private void soundStatusClick(object sender, EventArgs e)
        {
            soundCheck = !soundCheck; // Đảo ngược trạng thái
            UpdateSoundButtonAppearance();
        }

    }
}
