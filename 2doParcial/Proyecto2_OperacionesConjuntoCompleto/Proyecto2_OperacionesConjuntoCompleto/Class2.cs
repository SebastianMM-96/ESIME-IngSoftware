using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_OperacionesConjuntoCompleto
{
    class Arreglos2
    {
        private int n;
        private double[] elem2;

        public Arreglos2(int n)
        {
            this.n = n;
            elem2 = new double[n];
        }

        public int N
        {
            set
            {
                n = value;
            }

            get
            {
                return (n);
            }
        }

        public double[] Elem2
        {
            set
            {
                elem2 = value;
            }

            get
            {
                return (elem2);
            }
        }
    }
}
