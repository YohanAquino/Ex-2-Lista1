using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2_LISTA_1_Yohan_Aquino
{
    class Quadrado
    {
        private double l;
        private double a;

        public void setLado(double x)
        {
            l = x;
        }

        public void calcularArea()
        {
            a = Math.Pow(l, 2);
        }
        public double getArea()
        {
            return a;
        }

    }
}
