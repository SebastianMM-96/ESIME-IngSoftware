using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamiento_Matrices
{
    public partial class Form1 : Form
    {

        int m, n;
        Matrices A;
        TextBox[,] tB_mat;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Operacion_Click(object sender, EventArgs e)
        {

            A = new Matrices(m, n);

            if (rB_leer.Checked || rB_Poner.Checked || rB_Suma.Checked)
            {
                for(int i=0; i<m; i++)
                {
                    for(int j=0; j<n; j++)
                    {
                        A.Elem[i, j] = double.Parse(tB_mat[i, j].Text);
                    }
                }
            }
            // Trouble! FIX
            if (rB_Poner.Checked)
            {
                for (int i = 0; i < m; i++)
                {
                    String aux = " ";

                    for (int j = 0; j < n; j++)
                    {
                        aux = aux + A.Elem[i, j].ToString() + " ";
                    }
                    lB_result.Items.Add(aux);
                    aux = "";
                }
            }

            if (rB_Suma.Checked)
            {
                double suma;
                suma = A.Suma();
                lB_result.Items.Add("Suma de la Matriz: " + suma);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_Marroquin.exe");
        }

        private void firmaDelDesarrolladorWPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_WPF.exe");
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tamanio_Click(object sender, EventArgs e)
        {
            m = int.Parse(tB_m.Text);
            n = int.Parse(tB_n.Text);
            tB_mat = new TextBox[m, n];

            // Generar textBox_mat

            for(int i=0; i<m; i++)
            {
                for(int j=0; j<n; j++)
                {
                    tB_mat[i, j] = new TextBox();
                    tB_mat[i, j].Width = 60;
                    tB_mat[i, j].Height = 30;
                    tB_mat[i, j].Location = new Point(j * 60, i * 30);
                    panel_tBmat.Controls.Add(tB_mat[i, j]);
                }
            }
        }
    }
}
