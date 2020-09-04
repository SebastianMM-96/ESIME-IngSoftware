using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesplegarArreglo
{
    public partial class Form1 : Form
    {

        int m;
        Arreglos a;

        public Form1()
        {
            InitializeComponent();
        }

        private void salirDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_Marroquin.exe");
        }

        private void tam_btn_Click(object sender, EventArgs e)
        {
            m = int.Parse(tB_m.Text);
            a = new Arreglos(m);
        }

        private void leer_btn_Click(object sender, EventArgs e)
        {
            String c;

            for(int i = 0; i < a.M; i++)
            {
                c = tB_Elements.Lines[i].ToString();
                a.Elem[i] = double.Parse(c);
            }
        }

        private void poner_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.M; i++)
            {
                lBarr.Items.Add(a.Elem[i]);
            }
        }
    }
}
