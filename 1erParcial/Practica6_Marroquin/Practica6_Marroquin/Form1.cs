using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6_Marroquin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_Marroquin.exe");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Azcapotzalco.pdf");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("GustavoAMadero.pdf");
        }

        private void label20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MiguelHidalgo.pdf");
        }

        private void label21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Cuahutemoc.pdf");
        }

        private void label22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("VenustianoCarranza.pdf");
        }

        private void label23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Cuajimalpa.pdf");
        }

        private void label24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("AlvaroObregon.pdf");
        }

        private void label25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("BenitoJuarez.pdf");
        }

        private void label26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Iztacalco.pdf");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MagdalenaContreras.pdf");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Coyoacan.pdf");
        }

        private void label27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MagdalenaContreras.pdf");
        }

        private void label29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Iztapalapa.pdf");
        }

        private void label35_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Tlalpan.pdf");
        }

        private void label34_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Xochimilco.pdf");
        }

        private void label30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Tlahuac.pdf");
        }

        private void label36_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MilpaAlta.pdf");
        }
    }
}
