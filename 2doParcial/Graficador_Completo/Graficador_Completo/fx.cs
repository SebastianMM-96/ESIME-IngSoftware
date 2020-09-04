using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador_Completo
{
    class fx
    {
        private int colu, fil, col_ini = 1, col_final, fila_ini = 1, fila_final, n;
        private double x, y, cordxi = -5, cordxf = 5, cordyi = -5, cordyf = 5, h, b1, b2;
        public int[] Column;
        public int[] Row;

        public void Graficarxy(int columnafinal, int filafinal)
        {
            this.col_final = columnafinal;
            this.fila_final = filafinal;

            n = columnafinal - col_ini;
            h = (cordxf - cordxi) / n;

            Column = new int[n];
            Row = new int[n];

            for (int k = 0; k < n; k++)
            {
                x = cordxi + (k * h);
                y = Funcion(x);
                colu = Columna(x);
                fil = Fila(y);
                Column[k] = colu;
                Row[k] = fil;
            }
        }

        public int Columna(double x)
        {
            int Co;
            Co = (int)(((cordxf - x) * col_ini) / (cordxf - cordxi) + ((x - cordxi) * col_final) / (cordxf - cordxi));
            return Co;
        }

        public int Fila(double x)
        {
            int Fila;
            Fila = (int)(((cordyf - y) * fila_final) / (cordyf - cordyi) + ((y - cordyi) * fila_ini) / (cordyf - cordyi));
            return Fila;
        }

        public double Funcion(double x)
        {
            double Fun;
            Fun = (Math.Sin(x));
            return Fun;
        }
    }
}
