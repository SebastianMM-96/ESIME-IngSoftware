using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador_Funciones_WPF
{
    class Graficas
    {
        private int n, ci, cf, fi, ff;
        private double x, y, xi, xf, yi, yf, h;
        public int[] c;
        public int[] f;

        public Graficas(int n)
        {
            this.n = n;
            c = new int[n];
            f = new int[n];
        }

        public void graficadorxy(double xi, double xf, int cf, int ff)
        {
            ci = 1;
            fi = 1;
            yi = -10;
            yf = 10;
            this.cf = cf;
            this.ff = ff;
            this.xi = xi;
            this.xf = xf;

            h = (xf - xi) / n;
            
            for (int k=0; k < n; k++)
            {
                x = xi + k * h;
                y = Fu(x);
                c[k] = Col(x);
                f[k] = Fil(y);
            }
        }

        double Fu(double x)
        {   
            // Función Coseno
            double r;
            r = Math.Sin(x);
            return (r);
        }

        int Col(double x)
        {
            int co;
            co = (int)((x - xi) / (xf - xi) * (cf) + (xf - x) / (xf - xi) * (ci));
            return (co);
        }

        int Fil(double y)
        {
            int fila;
            fila = (int)((y - yi) / (yf - yi) * (fi) + (yf - y) / (yf - yi) * (ff));
            return (fila);
        }
    }
}
