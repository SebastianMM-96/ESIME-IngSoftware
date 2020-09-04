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


namespace Practica16_Marroquin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void funcion_Click(object sender, EventArgs e)
        {
            String fx;
            double x, r;
            x = double.Parse(textBox_fx_valor1.Text);
            fx = textBox_fx.Text;
            r = fu(x, fx);
            listBox_Result_Function.Items.Add(r);
        }

        double fu(double x, String fx)
        {
            double r;
            ExpressionParser ec1 = new ExpressionParser();
            ec1.Values.Add("x", x);
            r = ec1.Parse(fx);
            return (r);

        }

        private void salirDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Firma del alumno. 
            System.Diagnostics.Process.Start("Practica2_Marroquin.exe");
        }
    }
}
