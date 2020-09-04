using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador_Completo
{
    class Polares
    {
        private int col, fila, col_ini = 2, col_fil, fi = 2, filas, n;
        private double x, y, cor_dx = -5, cor_dx_final = 5, corr_dy_ini = -5, corr_dy_final = 5, h, b1, b2, theta, r;
        public int[] Column;
        public int[] Row;

        public void Graficador_Polar(int col_fil, int filas)
        {
            this.col_fil = col_fil;
            this.filas = filas;

            n = col_fil - col_ini;
            h = (cor_dx_final - cor_dx) / n;

            Column = new int[n];
            Row = new int[n];

            for (int k = 0; k < n; k++)
            {
                theta = cor_dx + (k * h);
                r = Function(theta);
                x = r * Math.Cos(theta);
                y = r * Math.Sin(theta);
                col = Columna(x);
                fila = Fila(y);
                Column[k] = col;
                Row[k] = fila;
            }
        }

        public int Columna(double x)
        {
            int Co;
            Co = (int)(((cor_dx_final - x) * col_ini) / (cor_dx_final - cor_dx) + ((x - cor_dx) * col_fil) / (cor_dx_final - cor_dx));
            return Co;
        }

        public int Fila(double y)
        {
            int Fi;
            Fi = (int)(((corr_dy_final - y) * filas) / (corr_dy_final - corr_dy_ini) + ((y - corr_dy_ini) * fi) / (corr_dy_final - corr_dy_ini));
            return Fi;

        }

        public double Function(double x)
        {
            double exp;
            exp = x;
            return exp;
        }
    }
}
