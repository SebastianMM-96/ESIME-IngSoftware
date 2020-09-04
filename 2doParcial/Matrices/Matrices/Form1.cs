using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {

        int m, n;
        Matrices A;


        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_Marroquin.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Tamanio_Click(object sender, EventArgs e)
        {
            m = int.Parse(tB_m.Text);
            n = int.Parse(tB_n.Text);

            A = new Matrices(m, n);
        }

        private void btn_Operacion_Click(object sender, EventArgs e)
        {
            String[] aux;

            if (rB_leer.Checked)
            {
                for(int i=0; i < m; i++)
                {
                    aux = tB_Element.Lines[i].Split(',');

                    for(int j=0; j < n; j++)
                    {
                        A.Elem[i, j] = double.Parse(aux[j]);
                    }
                }
            }

            if (rB_Poner.Checked)
            {
                for(int i=0; i<m; i++)
                {
                    for(int j=0; j<n; j++)
                    {
                        lB_result.Items.Add("Elemento de la Matriz: " + A.Elem[i, j]);
                    }
                }
            }


            if (rB_Suma.Checked)
            {
                double suma;
                suma = A.Suma();
                lB_result.Items.Add("Suma de la Matriz: "+suma);
            }

        }

        

        private void firmaDelDesarrolladorWPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_WPF.exe");
        }
    }
}
