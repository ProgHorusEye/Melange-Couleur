using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class melcoul : Form
    {
        public melcoul()
        {
            InitializeComponent();
        }

        int MycolorR;
        int MycolorV;
        int MycolorB;

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialisation curseur rouge
            hScrollBarRouge.Minimum = 0;
            hScrollBarRouge.Maximum = 264;
            hScrollBarRouge.SmallChange = 10;
            hScrollBarRouge.LargeChange = 10;
            hScrollBarRouge.Value = 0;
            numericUpRouge.Minimum = 0;
            numericUpRouge.Maximum = 255;

            //initialisation curseur vert
            hScrollBarVert.Minimum = 0;
            hScrollBarVert.Maximum = 264;
            hScrollBarVert.SmallChange = 10;
            hScrollBarVert.LargeChange = 10;
            hScrollBarVert.Value = 0;
            numericUpVert.Minimum = 0;
            numericUpVert.Maximum = 255;

            //initialisation curseur bleu
            hScrollBarBleu.Minimum = 0;
            hScrollBarBleu.Maximum = 264;
            hScrollBarBleu.SmallChange = 10;
            hScrollBarBleu.LargeChange = 10;
            hScrollBarBleu.Value = 0;
            numericUpBleu.Minimum = 0;
            numericUpBleu.Maximum = 255;
            
        }

        private void changescroll()
        {
            MycolorR = hScrollBarRouge.Value;
            MycolorV = hScrollBarVert.Value;
            MycolorB = hScrollBarBleu.Value;

            labelrouge.BackColor = Color.FromArgb(MycolorR, 0, 0);
            numericUpRouge.Value = MycolorR;
            labelresult.BackColor = Color.FromArgb(MycolorR, MycolorV, MycolorB);

            labelvert.BackColor = Color.FromArgb(0, MycolorV, 0);
            numericUpVert.Value = MycolorV;
            labelresult.BackColor = Color.FromArgb(MycolorR, MycolorV, MycolorB);

            labelbleu.BackColor = Color.FromArgb(0, 0, MycolorB);
            numericUpBleu.Value = MycolorB;
            labelresult.BackColor = Color.FromArgb(MycolorR, MycolorV, MycolorB);
        }

        private void changenum()
        {
            MycolorR = Convert.ToInt32(numericUpRouge.Value);
            MycolorV = Convert.ToInt32(numericUpVert.Value);
            MycolorB = Convert.ToInt32(numericUpBleu.Value);
            hScrollBarRouge.Value = MycolorR;
            hScrollBarVert.Value = MycolorV;
            hScrollBarBleu.Value = MycolorB;
            labelresult.BackColor = Color.FromArgb(MycolorR, MycolorV, MycolorB);
        }

        private void hScrollBarRouge_ValueChanged(object sender, EventArgs e)
        {
            changescroll();
        }

        private void hScrollBarVert_ValueChanged(object sender, EventArgs e)
        {
            changescroll();
        }

        private void hScrollBarBleu_ValueChanged(object sender, EventArgs e)
        {
            changescroll();
        }

        private void numericUpRouge_ValueChanged(object sender, EventArgs e)
        {
            changenum();
        }

        private void numericUpVert_ValueChanged(object sender, EventArgs e)
        {
            changenum();
        }

        private void numericUpBleu_ValueChanged(object sender, EventArgs e)
        {
            changenum();
        }
    }
}
