using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MatricesRealesComplejas
{
    class Matrices
    {
        private int m, n;
        private double[,] elem;
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
            get { return (m); }
        }
        public double[,] Elem
        {
            set { elem = value; }
            get { return (elem); }
        }
    }
}
