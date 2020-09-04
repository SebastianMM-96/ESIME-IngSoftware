using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2_OperacionesConjuntoCompleto
{
    public partial class Form1 : Form
    {
        int m; //Arreglo de números reales
        int n; //Arreglo de números imaginarios
        int pos, r;

        Arreglos a; //Arreglo 1
        Arreglos2 b; //Arreglos 2
        Arreglos f, g;

        double S, Z, Num;

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Obtener el tamaño del arreglo de números reales
        private void tam_btn_Click(object sender, EventArgs e)
        {
            m = int.Parse(tB_m.Text);
            a = new Arreglos(m);
            f = new Arreglos(m);
            g = new Arreglos(m);
        }

        // Leer el arreglo de números reales 
        private void leer_btn_Click(object sender, EventArgs e)
        {
            String c;

            for (int i = 0; i < a.M; i++)
            {
                c = tB_Elements.Lines[i].ToString();
                a.Elem[i] = double.Parse(c);
            }
        }
        // Insertamos el arreglo de números reales en la caja de lBarr
        private void poner_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.M; i++)
            {
                lBarr.Items.Add(a.Elem[i] + "\n");
            }
        }

        // Obtener el tamaño del arreglo de imaginarios
        private void tam2_btn_Click(object sender, EventArgs e)
        {
            n = int.Parse(tB_img.Text);
            b = new Arreglos2(n);
        }

        // Leer elementos del arreglo de números imaginarios
        private void leer1_btn_Click(object sender, EventArgs e)
        {
            String c;

            for (int i = 0; i < b.N; i++)
            {
                c = tB_Elements1.Lines[i].ToString();
                b.Elem2[i] = double.Parse(c);
            }

        }

        // Insertamos en lBarr el arreglo de números imaginarios
        private void poner1_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b.N; i++)
            {
                lBarr.Items.Add(b.Elem2[i] + "i" + "\n");
            }
        }

        private void firmaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica2_Marroquin.exe");
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            lBarr.Items.Clear();
        }

        /*
         * Operaciones básicas con los dos arreglos (real e imaginario)
         */

        private void btn_MenorReal_Click(object sender, EventArgs e)
        {
            double menor = a.Elem[0];

            for (int i = 1; i < a.M; i++)
            {
                if (menor > a.Elem[i])
                {
                    menor = a.Elem[i];
                }
            }
            lBarr.Items.Add("El menor elemento del arreglo R es: " + menor);
        }

        private void btn_MayorReal_Click(object sender, EventArgs e)
        {
            double mayor = 0;
            for (int i = 0; i < a.M; i++)
            {
                if (mayor < a.Elem[i])
                {
                    mayor = a.Elem[i];
                }
            }

            lBarr.Items.Add("El mayor elemento del arreglo R es: " + mayor);
        }

        private void btn_PromReal_Click(object sender, EventArgs e)
        {
            double promedio;
            double aux = 0;
            int cont = 0;
            for (int i = 0; i < a.M; i++)
            {
                cont = cont + 1;
                aux = aux + a.Elem[i];
            }
            promedio = (aux / cont);
            lBarr.Items.Add("El promedio del arreglo R es: " + promedio);
        }

        private void btn_PromImag_Click(object sender, EventArgs e)
        {
            double promedio;
            double aux = 0;
            int cont = 0;
            for (int i = 0; i < b.N; i++)
            {
                cont = cont + 1;
                aux = aux + b.Elem2[i];
            }
            promedio = (aux / cont);
            lBarr.Items.Add("El promedio del arreglo Imag. es: " + promedio + "i");
        }

        private void btn_OrdReal_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 7; j++)
            {
                lBarr.Items.Clear();
                double aux;
                for (int i = 0; i < (a.M) - 1; i++)
                {
                    if (a.Elem[i] > a.Elem[i + 1])
                    {
                        aux = a.Elem[i];
                        a.Elem[i] = a.Elem[i + 1];
                        a.Elem[i + 1] = aux;
                        lBarr.Items.Add("El orden del arreglo R es: " + a.Elem[i + 1]);
                    }
                    else
                    {
                        lBarr.Items.Add("El orden del arreglo R es: " + a.Elem[i]);
                    }
                }
                lBarr.Items.Add("El orden del arreglo R es: " + a.Elem[(a.M) - 1]);
            }
        }

        private void btn_InvertReal_Click(object sender, EventArgs e)
        {
            Array.Reverse(a.Elem);
            for (int i = 0; i < a.M; i++)
            {
                lBarr.Items.Add("El inverso del arreglo R es: " + a.Elem[i]);
            }
        }

        private void btn_MenorImag_Click(object sender, EventArgs e)
        {
            double menor = b.Elem2[0];
            for (int i = 1; i < b.N; i++)
            {
                if (menor > b.Elem2[i])
                {
                    menor = b.Elem2[i];
                }
            }

            lBarr.Items.Add("El menor elemento del arreglo Imag. es: " + menor + "i");
        }

        private void btn_MayorImag_Click(object sender, EventArgs e)
        {
            double mayor = 0;
            for (int i = 0; i < b.N; i++)
            {
                if (mayor < b.Elem2[i])
                {
                    mayor = b.Elem2[i];
                }
            }

            lBarr.Items.Add("El mayor elemento del arreglo Imag. es: " + mayor + "i");
        }

        private void btn_OrdImag_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 7; j++)
            {
                lBarr.Items.Clear();
                double aux;
                for (int i = 0; i < (b.N) - 1; i++)
                {
                    if (b.Elem2[i] > b.Elem2[i + 1])
                    {
                        aux = b.Elem2[i];
                        b.Elem2[i] = b.Elem2[i + 1];
                        b.Elem2[i + 1] = aux;
                        lBarr.Items.Add("El orden del arreglo Imag. es: " + b.Elem2[i + 1] + "i");
                    }
                    else
                    {
                        lBarr.Items.Add("El orden del arreglo Imag. es: " + b.Elem2[i] + "i");
                    }
                }
                lBarr.Items.Add("El orden del arreglo Imag. es: " + b.Elem2[(b.N) - 1] + "i");
            }
        }

        private void btn_InvertImag_Click(object sender, EventArgs e)
        {
            Array.Reverse(b.Elem2);
            for (int i = 0; i < b.N; i++)
            {
                lBarr.Items.Add("El inverso del arreglo Imag. es: " + b.Elem2[i] + "i");
            }
        }

        /*
         * Operaciones especiales utilizando datos extra
         */

        // Obtener Real S
        private void btn_CapturaRealS_Click(object sender, EventArgs e)
        {
            S = double.Parse(txtBx_RealS.Text);
        }

        private void btn_FindNReal_Click(object sender, EventArgs e)
        {
            Num = double.Parse(txtBx_DatoN.Text);
            for (int i = 0; i < a.M; i++)
            {
                if (a.Elem[i] == Num)
                {
                    lBarr.Items.Add(a.Elem[i] + "= [" + i + "]");
                }
            }
        }

        private void btn_FindNImag_Click(object sender, EventArgs e)
        {
            Num = double.Parse(txtBx_DatoN.Text);
            for (int i = 0; i < b.N; i++)
            {
                if (b.Elem2[i] == Num)
                {
                    lBarr.Items.Add(b.Elem2[i] + "i = [" + i + "]");
                }
            }
        }

        // "Z" + Núm. complejo
        private void button3_Click(object sender, EventArgs e)
        {
            Z = double.Parse(txtBx_ImagZ.Text);
            for (int i = 0; i < a.M; i++)
            {
                f.Elem[i] = b.Elem2[i] + Z;
                lBarr.Items.Add(a.Elem[i] + "+" + f.Elem[i] + "i");
            }
        }

        // "Z" * Núm. compeljo
        private void button4_Click(object sender, EventArgs e)
        {
            Z = double.Parse(txtBx_ImagZ.Text);
            for (int i = 0; i < a.M; i++)
            {
                f.Elem[i] = b.Elem2[i] * Z * -1;
                g.Elem[i] = a.Elem[i] * Z;
                lBarr.Items.Add(g.Elem[i] + "i +" + f.Elem[i]);
            }
        }

        //Núm. complejo - "S"
        private void button5_Click(object sender, EventArgs e)
        {
            S = double.Parse(txtBx_RealS.Text);
            for (int i = 0; i < a.M; i++)
            {
                f.Elem[i] = a.Elem[i] - S;
                lBarr.Items.Add(f.Elem[i] + " + " + b.Elem2[i] + "i");
            }
        }

        // Núm. complejo - "Z"
        private void button6_Click(object sender, EventArgs e)
        {
            Z = double.Parse(txtBx_ImagZ.Text);
            for (int i = 0; i < a.M; i++)
            {
                f.Elem[i] = b.Elem2[i] - Z;
                lBarr.Items.Add(a.Elem[i] + " + " + f.Elem[i] + "i");
            }
        }

        // Núm complejo / "S"
        private void button7_Click(object sender, EventArgs e)
        {
            S = double.Parse(txtBx_RealS.Text);
            for (int i = 0; i < a.M; i++)
            {
                f.Elem[i] = a.Elem[i] / S;
                g.Elem[i] = b.Elem2[i] / S;
                lBarr.Items.Add(f.Elem[i] + " + " + g.Elem[i] + "i");
            }
        }

        // Mostrar el número complejo obtenido
        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.M; i++)
            {
                lBarr.Items.Add("El número complejo es: " + a.Elem[i] + " + " + b.Elem2[i] + "i");
            }
        }



        // Suma de un S + Núm. complejo
        private void button1_Click(object sender, EventArgs e)
        {
            S = double.Parse(txtBx_RealS.Text);
            for (int i = 0; i < a.M; i++)
            {
                f.Elem[i] = a.Elem[i] + S;
                lBarr.Items.Add(f.Elem[i] + "+" + b.Elem2[i] + "i");
            }
        }

        // "S" * Núm. complejo
        private void button2_Click(object sender, EventArgs e)
        {
            S = double.Parse(txtBx_RealS.Text);
            for (int i = 0; i < a.M; i++)
            {
                f.Elem[i] = a.Elem[i] * S;
                g.Elem[i] = b.Elem2[i] * S;
                lBarr.Items.Add(f.Elem[i] + "+" + g.Elem[i] + "i");
            }
        }

        // Obtener Imaginario Z
        private void btn_CapturaImagZ_Click(object sender, EventArgs e)
        {
            Z = double.Parse(txtBx_ImagZ.Text);
        }

        // Obtener Dato N para realizar búsquedas 
        private void btn_CapturaDatoN_Click(object sender, EventArgs e)
        {
            Num = double.Parse(txtBx_DatoN.Text);
        }


    }
}
