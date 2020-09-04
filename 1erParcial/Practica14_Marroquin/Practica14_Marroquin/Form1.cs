using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica14_Marroquin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Suma_btn_Click(object sender, EventArgs e)
        {

            double x, y, r;
            x = double.Parse(txtBox_valor1.Text);
            y = double.Parse(txtBox_valor2.Text);
            r = x + y;
            listBox_Result.Items.Add(r);
        }

        private void Multi_btn_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(txtBox_valor1.Text);
            y = double.Parse(txtBox_valor2.Text);
            r = x * y;
            listBox_Result.Items.Add(r);
        }

        private void Pot_btn_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(txtBox_valor1.Text);
            y = double.Parse(txtBox_valor2.Text);
            r = Math.Pow(x, y);
            listBox_Result.Items.Add(r);
        }

        private void potCuadrada_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Pow(x, 2);
            listBox_Result.Items.Add(r);
        }

        private void potCubica_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Pow(x, 3);
            listBox_Result.Items.Add(r);
        }

        private void Resta_btn_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(txtBox_valor1.Text);
            y = double.Parse(txtBox_valor2.Text);
            r = x - y;
            listBox_Result.Items.Add(r);
        }

        private void Div_btn_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(txtBox_valor1.Text);
            y = double.Parse(txtBox_valor2.Text);
            r = x / y;
            listBox_Result.Items.Add(r);
        }

        private void logNat_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Log(x);
            listBox_Result.Items.Add(r);
        }

        private void raizC_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Sqrt(x);
            listBox_Result.Items.Add(r);
        }

        private void exp_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Exp(x);
            listBox_Result.Items.Add(r);
        }

        private void Eleveted10_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Pow(10, x);
            listBox_Result.Items.Add(r);
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Log10(x);
            listBox_Result.Items.Add(r);
        }

        private void divx_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = 1 / x;
            listBox_Result.Items.Add(r);
        }

        private void abs_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Abs(x);
            listBox_Result.Items.Add(r);
        }

        private void pot2x_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_valor1.Text);
            r = Math.Pow(2, x);
            listBox_Result.Items.Add(r);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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
