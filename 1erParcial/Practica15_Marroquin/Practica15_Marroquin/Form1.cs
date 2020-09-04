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

namespace Practica15_Marroquin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sin_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = (Math.Sin(x));
            listBox_trigo.Items.Add(r);
        }

        private void cos_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = x * (Math.Cos(x));
            listBox_trigo.Items.Add(r);
        }

        private void tan_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = x * (Math.Tan(x));
            listBox_trigo.Items.Add(r);
        }

        private void cot_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = Math.Cos(x) / Math.Sin(x);
            listBox_trigo.Items.Add(r);
        }

        private void sec_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = 1 / Math.Cos(x);
            listBox_trigo.Items.Add(r);
        }

        private void csc_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = 1 / Math.Sin(x);
            listBox_trigo.Items.Add(r);
        }

        private void tanh_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = (Math.Tanh(x));
            listBox_trigo.Items.Add(r);
        }

        private void sinh_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = (Math.Sinh(x));
            listBox_trigo.Items.Add(r);
        }

        private void cosh_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = (Math.Cosh(x));
            listBox_trigo.Items.Add(r);
        }

        private void arcSin_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = (Math.Asin(x));
            listBox_trigo.Items.Add(r);
        }

        private void arcCos_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = (Math.Acos(x));
            listBox_trigo.Items.Add(r);
        }

        private void arcTan_btn_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(txtBox_Trigo1.Text);
            //y = double.Parse(txtBox_Trigo2.Text);
            r = (Math.Atan(x));
            listBox_trigo.Items.Add(r);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
