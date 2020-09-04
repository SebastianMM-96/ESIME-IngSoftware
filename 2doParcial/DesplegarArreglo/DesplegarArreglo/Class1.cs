using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesplegarArreglo
{
    class Arreglos
    {
        private int m;
        private double[] elem;

        public Arreglos(int m)
        {
            this.m = m;
            elem = new double[m];
        }

        public int M
        {
            set
            {
                m = value;
            }

            get
            {
                return (m);
            }
        }

        public double[] Elem
        {
            set
            {
                elem = value;
            }

            get
            {
                return (elem);
            }
        }

    }
}
