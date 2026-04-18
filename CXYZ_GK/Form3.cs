using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXYZ
{
    public partial class Form3 : Form
    {
        private int currentScore;
        public Form3(int score)
        {
            InitializeComponent();
            this.currentScore = score;
            overPoint.Text = "Bạn đã ghi được " + score + " điểm!";
        }
        
        

    }
}
