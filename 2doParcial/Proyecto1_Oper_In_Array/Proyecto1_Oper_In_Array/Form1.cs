using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Oper_In_Array
{
    public partial class Form1 : Form
    {
        int m; //Arreglo1
        int n; //Arreglo2
        Arreglos a, save; //Arreglo 1
        Arreglos2 b; //Arreglos 2

        double escalar;
        int position;
        double number;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void salirDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Tam Arreglo 1
        private void tam_btn_Click(object sender, EventArgs e)
        {
            m = int.Parse(tB_m.Text);
            a = new Arreglos(m);
            save = new Arreglos(m);
        }

        //Tam Arreglo 2
        private void tam2_btn_Click(object sender, EventArgs e)
        {
            n = int.Parse(tB_n.Text);
            b = new Arreglos2(n);
        }

        //Leer Arreglo 1
        private void leer_btn_Click(object sender, EventArgs e)
        {
            String c;

            for (int i = 0; i < a.M; i++)
            {
                c = tB_Elements.Lines[i].ToString();
                a.Elem[i] = double.Parse(c);
            }
        }

        //Leer Arreglo 2
        private void leer2_btn_Click(object sender, EventArgs e)
        {
            String c;

            for (int i = 0; i < b.N; i++)
            {
                c = tB_Elements2.Lines[i].ToString();
                b.Elem2[i] = double.Parse(c);
            }
        }

        // Poner Arreglo 1
        private void poner_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.M; i++)
            {
                lBarr.Items.Add(a.Elem[i]);
            }
        }

        //Poner Arreglo 2
        private void poner2_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b.N; i++)
            {
                lBarr.Items.Add(b.Elem2[i]);
            }
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            lBarr.Items.Clear();
        }


        /*
         * Operaciones básicas del Arreglo A1
         */

        // Suma Arreglo 1
        private void suma_btn_Click(object sender, EventArgs e)
        {
            double suma = 0;
            for (int i = 0; i < a.M; i++)
            {
                suma += a.Elem[i];
            }
            lBarr.Items.Add("Suma del Arreglo A1:" + suma);
        }

        // Reverso del Arreglo 1
        private void reverse_btn_Click(object sender, EventArgs e)
        {

            for (int i = a.M - 1; i >= 0; i--)
            {
                lBarr.Items.Add("Reverso del Arreglo A1:" + a.Elem[i]);
            }
        }

        // Max/Min del Arreglo 1
        private void max_btn_Click(object sender, EventArgs e)
        {
            double max = 0;
            double min = 0;
            for (int i = 0; i < a.M; i++)
            {
                if(a.Elem[i] > max)
                {
                    max = a.Elem[i];
                }

                if (a.Elem[i] < min)
                {
                    min = a.Elem[i];
                }
            }
            lBarr.Items.Add("Maximo del Arreglo A1:" + max);
            lBarr.Items.Add("Minimo del Arreglo A1:" + min);
        }

        // Arreglo Ascendente
        private void asc_btn_Click(object sender, EventArgs e)
        {
            double n, tmp;
            n = 0;
            tmp = 0;

            for (int i = 0; i < a.M; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a.Elem[j] < a.Elem[i])
                    {
                        tmp = a.Elem[i];
                        a.Elem[i] = a.Elem[j];
                        a.Elem[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < a.M; i++)
            {
                lBarr.Items.Add("Forma ascendente del Arreglo A1:" + a.Elem[i]);
            }
        }

        private void promA1_btn_Click(object sender, EventArgs e)
        {
            double prom;
            double acum = 0;
            int cont = 0;
            for (int i = 0; i < a.M; i++)
            {
                cont = cont + 1;
                acum = acum + a.Elem[i];
            }
            prom = acum / cont;
            lBarr.Items.Add("Promedio del Arreglo 1:" + prom);
        }

        /*
         * Operaciones Basicas del Arreglo A2
         */

        // Ascendente del Arreglo 2
        private void ascA2_btn_Click(object sender, EventArgs e)
        {
            double n, tmp;
            n = 0;
            tmp = 0;

            for (int i = 0; i < b.N; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (b.Elem2[j] < b.Elem2[i])
                    {
                        tmp = b.Elem2[i];
                        b.Elem2[i] = b.Elem2[j];
                        b.Elem2[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < b.N; i++)
            {
                lBarr.Items.Add("Forma ascendente del Arreglo A2:" + b.Elem2[i]);
            }
        }

        // Reverso del Arreglo 2
        private void reverseA2_btn_Click(object sender, EventArgs e)
        {
            for (int i = b.N - 1; i >= 0; i--)
            {
                lBarr.Items.Add("Reverso del Arreglo A2:" + b.Elem2[i]);
            }
        }

        // Maximo y minimo del Arreglo A2
        private void maxMinA2_btn_Click(object sender, EventArgs e)
        {
            double max = 0;
            double min = 0;
            for (int i = 0; i < b.N; i++)
            {
                if (b.Elem2[i] > max)
                {
                    max = b.Elem2[i];
                }

                if (b.Elem2[i] < min)
                {
                    min = b.Elem2[i];
                }
            }
            lBarr.Items.Add("Maximo del Arreglo A2:" + max);
            lBarr.Items.Add("Minimo del Arreglo A2:" + min);
        }

        // Suma del Arreglo A2
        private void sumaA2_btn_Click(object sender, EventArgs e)
        {
            double suma = 0;
            for (int i = 0; i < b.N; i++)
            {
                suma += b.Elem2[i];
            }
            lBarr.Items.Add("Suma del Arreglo A2:" + suma);
        }

        private void promA2_btn_Click(object sender, EventArgs e)
        {
            double prom;
            double acum = 0;
            int cont = 0;
            for (int i = 0; i < b.N; i++)
            {
                cont = cont + 1;
                acum = acum + b.Elem2[i];
            }
            prom = acum / cont;
            lBarr.Items.Add("Promedio del Arreglo 2:" + prom);
        }

        private void button6_Click(object sender, EventArgs e)
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
                        lBarr.Items.Add(b.Elem2[i + 1]);
                    }
                    else
                    {
                        lBarr.Items.Add(b.Elem2[i]);
                    }
                }
                lBarr.Items.Add(b.Elem2[(b.N) - 1]);
            }
        }

        private void sortA1_btn_Click(object sender, EventArgs e)
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
                        lBarr.Items.Add(a.Elem[i + 1]);
                    }
                    else
                    {
                        lBarr.Items.Add(a.Elem[i]);
                    }
                }
                lBarr.Items.Add(a.Elem[(a.M) - 1]);
            }
        }

        private void restA1A2_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < a.M; i++)
            {
                save.Elem[i] = a.Elem[i] + b.Elem2[i];
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void divA1A2_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = a.Elem[i] - b.Elem2[i];
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void multA1A2_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = a.Elem[i] * b.Elem2[i];
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void sumA1A2_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = a.Elem[i] + b.Elem2[i];
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        // Operaciones utilizando el escalar

        private void escalar_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
        }

        private void ResA1Esc_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = a.Elem[i] - escalar;
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void DivA1Esc_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = a.Elem[i] / escalar;
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void EscDivA1_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = escalar / a.Elem[i];
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void EscMultA1_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = escalar * a.Elem[i];
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void SumA1Esc_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = a.Elem[i] + escalar;
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        // Operaciones escalar A2

        private void SumA2Esc_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = b.Elem2[i] + escalar;
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void A2DivEsc_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = b.Elem2[i] / escalar;
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void EscDivA2_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = escalar / b.Elem2[i];
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void EscMulA2_btn_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = escalar * b.Elem2[i];
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escalar = double.Parse(tB_escalar.Text);
            for (int i = 0; i < a.M; i++)
            {
                save.Elem[i] = b.Elem2[i] - escalar;
                lBarr.Items.Add(save.Elem[i]);
            }
        }

        // Find Position in Array

        private void getPos_btn_Click(object sender, EventArgs e)
        {
            position = int.Parse(tB_position.Text);
        }

        private void posA2_btn_Click(object sender, EventArgs e)
        {
            position = int.Parse(tB_position.Text);
            for (int i = 0; i < b.N; i++)
            {
                if (i == position)
                {
                    lBarr.Items.Add("[" + position + "]=" + b.Elem2[i]);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void posA1_btn_Click(object sender, EventArgs e)
        {
            position = int.Parse(tB_position.Text);
            for (int i = 0; i < a.M; i++)
            {
                if (i == position)
                {
                    lBarr.Items.Add("[" + position + "]=" + a.Elem[i]);
                }
            }
        }





    }
}
