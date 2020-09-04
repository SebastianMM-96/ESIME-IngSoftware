using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficador_Completo
{
    public partial class GraficadorCompleto : Form
    {
        public GraficadorCompleto()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_WPF.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_graphFunc_Click(object sender, EventArgs e)
        {
            int cf, ff, n, ci = 1;

            Graphics e1 = pB1.CreateGraphics();
            Graphics e2 = pB1.CreateGraphics();
            Graficador Graficador = new Graficador();

            cf = pB1.Width;
            ff = pB1.Height;
            string fx;

            fx = textBox1.Text;
            Graficador.Graficaxy(cf, ff, fx, e2);
            n = cf - ci;


            for (int k = 0; k < n - 1; k++)
            {
                e1.DrawLine(Pens.Red, Graficador.Column[k], Graficador.Row[k], Graficador.Column[k + 1], Graficador.Row[k + 1]);

            }
        }

        private void btn_OptGraph_Click(object sender, EventArgs e)
        {
            if (rBFx.Checked)
            {
                int colfinal, filafinal, n, colini = 2;

                Graphics e1 = pB1.CreateGraphics();
                fx function_fx = new fx();

                filafinal = pB1.Height;
                colfinal = pB1.Width;
                function_fx.Graficarxy(colfinal, filafinal);
                n = colfinal - colini;

                for (int j = 0; j < n - 1; j++)
                {
                    e1.DrawLine(Pens.BlueViolet, function_fx.Column[j], function_fx.Row[j], function_fx.Column[j + 1], function_fx.Row[j + 1]);

                }
            }
            if (rBParametricas.Checked)
            {
                int colfinal, filafinal, n, colini = 2;

                Graphics e1 = pB1.CreateGraphics();
                Parametricas parametric_fu = new Parametricas();

                filafinal = pB1.Height;
                colfinal = pB1.Width;
                parametric_fu.Graficar_Parametricas(colfinal, filafinal);
                n = colfinal - colini;

                for (int j = 0; j < n - 1; j++)
                {
                    e1.DrawLine(Pens.Green, parametric_fu.Column[j], parametric_fu.Row[j], parametric_fu.Column[j + 2], parametric_fu.Row[j + 2]);

                }
            }
            if (rBPolares.Checked)
            {
                int columnafila, filas, n, colini = 3;

                Graphics e1 = pB1.CreateGraphics();
                Polares polar_Func = new Polares();
                columnafila = pB1.Width;
                filas = pB1.Height;
                polar_Func.Graficador_Polar(columnafila, filas);
                n = columnafila - colini;

                for (int k = 0; k < n - 1; k++)
                {
                    e1.DrawLine(Pens.DarkBlue, polar_Func.Column[k], polar_Func.Row[k], polar_Func.Column[k + 2], polar_Func.Row[k + 2]);
                }
            }
            if (rbLissajous.Checked)
            {
                int colfinal, filafinal, n, colini = 2;

                Graphics e1 = pB1.CreateGraphics();
                Lissajous figures_Lissa = new Lissajous();

                filafinal = pB1.Height;
                colfinal = pB1.Width;
                figures_Lissa.Grafica_Lissajous(colfinal, filafinal);
                n = colfinal - colini;

                for (int j = 0; j < n - 1; j++)
                {
                    e1.DrawLine(Pens.Black, figures_Lissa.Column[j], figures_Lissa.Row[j], figures_Lissa.Column[j + 2], figures_Lissa.Row[j + 2]);
                }
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            pB1.Refresh();
        }
    }
}
