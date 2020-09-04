using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador_Completo
{
    class Parametricas
    {
        private int colu, fil, col_ini = 1, col_final, fila_ini = 1, fila_final, n;
        private double x, y, cor_dx_i = -7, cor_dx_f = 7, cor_dy_i = -7, cor_dy_f = 7, h, t;
        public int[] Column;
        public int[] Row;

        public void Graficar_Parametricas(int columnafinal, int filafinal)
        {
            this.col_final = columnafinal;
            this.fila_final = filafinal;

            n = columnafinal - col_ini;
            h = (cor_dx_f - cor_dx_i) / n;

            Column = new int[n];
            Row = new int[n];

            for (int k = 0; k < n; k++)
            {
                t = cor_dx_i + (k * h);
                x = FirstFunction(t);
                y = SecondFunction(t);
                colu = Columna(x);
                fil = Fila(y);
                Column[k] = colu;
                Row[k] = fil;
            }
        }

        public int Columna(double x)
        {
            int Co;
            Co = (int)(((cor_dx_f - x) * col_ini) / (cor_dx_f - cor_dx_i) + ((x - cor_dx_i) * col_final) / (cor_dx_f - cor_dx_i));
            return Co;
        }

        public int Fila(double y)
        {
            int Fila;
            Fila = (int)(((cor_dy_f - y) * fila_final) / (cor_dy_f - cor_dy_i) + ((y - cor_dy_i) * fila_ini) / (cor_dy_f - cor_dy_i));
            return Fila;

        }

        public double FirstFunction(double x)
        {
            double fu;
            fu = 4 * Math.Cos(x);
            return fu;
        }

        public double SecondFunction(double x)
        {
            double fu_2;
            fu_2 = 5 * Math.Sin(x);
            return fu_2;
        }
    }
}
