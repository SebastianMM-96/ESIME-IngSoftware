using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePaint
{
    public partial class Form1 : Form
    {

        public Boolean pencil;

        public Form1()
        {
            InitializeComponent();
        }

        private void pB1_MouseDown(object sender, MouseEventArgs e)
        {
            pencil = true;
        }

        private void pB1_MouseUp(object sender, MouseEventArgs e)
        {
            pencil = false;
        }

        private void pB1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = pB1.CreateGraphics();
            if (pencil == true)
            {
                g.DrawLine(Pens.Black, e.X, e.Y, e.X + 1, e.Y);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_WPF.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pB1.Refresh();
        }
    }
}
