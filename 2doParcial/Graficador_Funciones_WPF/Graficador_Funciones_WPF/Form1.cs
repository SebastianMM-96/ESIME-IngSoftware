using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficador_Funciones_WPF
{
    public partial class Form1 : Form
    {
        int ci, cf, n, ff;
        double Xi, Xf;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            pic1.Refresh();
        }

        private void firmaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_Marroquin.exe");
        }

        private void pic1_Click_1(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void oper_btn_Click(object sender, EventArgs e)
        {
            if (rB_graf.Checked)
            {
                pic1.Invalidate();
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Xi = double.Parse(tB_xi.Text);
            Xf = double.Parse(tB_xf.Text);
            ci = 1;
            cf = pic1.Width;
            ff = pic1.Height;
            n = cf - ci;

            Graficas gr = new Graficas(n);
            gr.graficadorxy(Xi, Xf, cf, ff);

            for (int k = 0; k < n-1; k++)
            {
                g.DrawLine(Pens.Blue, gr.c[k], gr.f[k], gr.c[k + 1], gr.f[k + 1]);
               
            }
        }
    }
}
