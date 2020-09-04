using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despertador_Alarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void stick_Tick(object sender, EventArgs e)
        {
            dato.Text = DateTime.Now.ToString("dd/MM/yyyy; hh:mm:ss:f");

            if (activar.Checked)
            {
                if(alarme.Text == dato.Text)
                {
                    //MP3 Song
                    Process.Start("AlarmBeep.mp3");
                    MessageBox.Show("Alarma!!");
                }
            }
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_WPF.exe");
        }
    }
}
