using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramingProject.Forms
{
    public partial class Paint_Form : Form
    {
        public Paint_Form()
        {
            InitializeComponent();
        }
        bool drw;
        int beginX;
        int beginY;
        private void Paint_Form_MouseUp(object sender, MouseEventArgs e)
        {
            drw = false;
        }
        private void Paint_Form_MouseDown(object sender, MouseEventArgs e)
        {
            drw = true;
            beginX = e.X;
            beginY = e.Y;
        }
        Pen p = new Pen(Color.Black, 4);
        private void Paint_Form_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point point1 = new Point(beginX, beginY);
            Point point2 = new Point(e.X, e.Y);
            if (drw == true)
            {
                g.DrawLine(p, point1, point2);
                beginX = e.X;
                beginY = e.Y;
            }
        }

        private void Paint_Form_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            p = new Pen(Color.White, 4);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            p = new Pen(Color.White, 4);
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            p = new Pen(Color.Black, 4);
        }

        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p = new Pen(colorDialog1.Color, 4);
            }
        }
    }
}
