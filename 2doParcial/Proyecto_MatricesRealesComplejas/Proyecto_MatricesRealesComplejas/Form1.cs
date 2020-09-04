using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;
using System.Numerics;

namespace Proyecto_MatricesRealesComplejas
{
    public partial class Form1 : Form
    {

        int m, n;
        TextBox[,] tbmat;
        TextBox[,] tbmat1;
        Matrices A, B;

        public Form1()
        {
            InitializeComponent();
        }

        private void firmaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_WPF.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Operacion_Click(object sender, EventArgs e)
        {
            A = new Matrices(m, n);
            B = new Matrices(m, n);

            if (rBleer.Checked || rBPoner.Checked || rBSuma.Checked)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A.Elem[i, j] = double.Parse(tbmat[i, j].Text);
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        B.Elem[i, j] = double.Parse(tbmat1[i, j].Text);
                    }
                }
            }

            if (rBPoner.Checked)
            {
                lB1.Items.Add("Matriz de reales");
                for (int i = 0; i < m; i++)
                {
                    String aux = " ";
                    for (int j = 0; j < n; j++)
                    {
                        aux = aux + A.Elem[i, j] + " ";
                    }
                    lB1.Items.Add(aux);
                    aux = "";
                }
                lB1.Items.Add("Matriz de imaginarios");
                for (int i = 0; i < m; i++)
                {
                    String aux1 = " ";
                    for (int j = 0; j < n; j++)
                    {
                        aux1 = aux1 + B.Elem[i, j] + " j ";
                    }
                    lB1.Items.Add(aux1);
                    aux1 = "";
                }
                lB1.Items.Add("Matriz de numeros complejos ");
                for (int i = 0; i < m; i++)
                {
                    String aux2 = " ";
                    for (int j = 0; j < n; j++)
                    {
                        aux2 = aux2 + new Complex(A.Elem[i, j], B.Elem[i, j]);

                    }
                    lB1.Items.Add("\n" + aux2);
                    aux2 = "";
                }
            }

            if (rBSuma.Checked)
            {
                double suma = 0;
                double suma1 = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        suma = suma + A.Elem[i, j];
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        suma1 = suma1 + B.Elem[i, j];
                    }

                }

                lB1.Items.Add("\nSuma de matriz real: " + suma);
                lB1.Items.Add("\nSuma de matriz compleja: " + suma1 + " j");
                lB1.Items.Add("\nSuma de numeros complejos: " + suma + "+" + suma1 + " j");
            }

            if (rbClean.Checked)
            {
                lB1.Items.Clear();
            }
        }

        private void btn_tam_Click(object sender, EventArgs e)
        {
            m = int.Parse(tBm.Text);
            n = int.Parse(tBn.Text);

            tbmat = new TextBox[m, n];
            tbmat1 = new TextBox[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tbmat[i, j] = new TextBox();
                    tbmat[i, j].Width = 60;
                    tbmat[i, j].Height = 30;
                    tbmat[i, j].Location = new Point(j * 60, i * 30);
                    panel1.Controls.Add(tbmat[i, j]);

                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tbmat1[i, j] = new TextBox();
                    tbmat1[i, j].Width = 60;
                    tbmat1[i, j].Height = 30;
                    tbmat1[i, j].Location = new Point(j * 60, i * 30);
                    panel2.Controls.Add(tbmat1[i, j]);

                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
