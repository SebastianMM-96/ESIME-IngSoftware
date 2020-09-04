using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Matrices
    {
        private int m, n;
        private double[,] elem;

        // Constructor de la matriz
        public Matrices(int m, int n)
        {
            M = m;
            N = n;
            Elem = new double[M, N];
        }

        public int M
        {
            set { m = value; }
            get { return (m); }
        }

        public int N
        {
            set { n = value; }
            get { return (n); }
        }

        public double[,] Elem
        {
            set { elem = value; }
            get { return (elem); }
        }

        public double Suma()
        {
            double suma = 0;

            for(int j=0; j<n; j++)
            {
                for(int i=0; i<m; i++)
                {
                    suma = suma + Elem[i, j];
                }
            }

            return (suma);
        }
    }
}
