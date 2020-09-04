using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMoteoAleatorio
{
    public partial class Form1 : Form
    {

        public Boolean pencil;

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_WPF.exe");
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
            if(pencil == true)
            {
                g.DrawLine(Pens.Black, e.X, e.Y, e.X + 1, e.Y);
            }
        }

        private void dibujar_Click(object sender, EventArgs e)
        {
            int R, G, B, x, y;

            Graphics g1 = pB1.CreateGraphics();
            Random rnd = new Random();

            if (moteo.Checked)
            {
                for (int i=1; i < 15000; i++)
                {
                    x = rnd.Next(pB1.Width);
                    y = rnd.Next(pB1.Height);
                    R = rnd.Next(255);
                    G = rnd.Next(255);
                    B = rnd.Next(255);

                    Color color = Color.FromArgb(100, R, G, B);

                    Pen pen = new Pen(color);

                    g1.DrawLine(pen, x, y, x+1, y);
                }
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            pB1.Refresh();
        }
    }
}
