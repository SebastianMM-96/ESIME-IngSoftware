using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;
using System.Drawing;

namespace Graficador_Completo
{
    class Graficador
    {
        private int columna, fila, col_ini = 1, col_fi, fila_ini = 1, ff, n;
        private double cordx, cordy, corx = -5, corxfinal = 5, yi = -5, yf = 5, h;
        public int[] Column;
        public int[] Row;
        public int[] ex;
        public int[] ey;
        string fx;

        public void Graficaxy(int cf, int ff, string fx, Graphics graphics)
        {
            this.col_fi = cf;
            this.ff = ff;
            this.fx = fx;

            n = cf - col_ini;
            h = (corxfinal - corx) / n;

            Row = new int[n];
            Column = new int[n];

            for (int k = 0; k < n; k++)
            {
                cordx = corx + (k * h);
                cordy = Function(cordx, fx);
                columna = Columna(cordx);
                fila = Fila(cordy);
                Column[k] = columna;
                Row[k] = fila;
            }
            X_axis(corx, corxfinal);
            Y_axis(corx, corxfinal);
            graphics.DrawLine(Pens.DarkBlue, ex[0], ex[1], ex[2], ex[3]);
            graphics.DrawLine(Pens.DarkBlue, ey[0], ey[1], ey[2], ey[3]);
        }

        public int Columna(double x)
        {
            int Co;
            Co = (int)(((corxfinal - x) * col_ini) / (corxfinal - corx) + ((x - corx) * col_fi) / (corxfinal - corx));
            return Co;
        }

        public int Fila(double y)
        {
            int Fi;
            Fi = (int)(((yf - y) * ff) / (yf - yi) + ((y - yi) * fila_ini) / (yf - yi));
            return Fi;

        }

        public void X_axis(double xi, double xf)
        {
            ex = new int[4];
            cordy = 0;
            fila = Fila(cordy);
            ex[0] = col_ini;
            ex[1] = fila;
            ex[2] = col_fi;
            ex[3] = fila;
        }

        public void Y_axis(double xi, double xf)
        {
            ey = new int[4];
            if (xi * xf < 0)
            {
                cordx = 0;
                columna = Columna(cordx);
                ey[0] = columna;
                ey[1] = col_ini;
                ey[2] = columna;
                ey[3] = col_fi;
            }
        }

        public double Function(double x, string fx)
        {
            ExpressionParser exp = new ExpressionParser();
            exp.Values.Add("x", x);
            return exp.Parse(fx);
        }

    }
}
