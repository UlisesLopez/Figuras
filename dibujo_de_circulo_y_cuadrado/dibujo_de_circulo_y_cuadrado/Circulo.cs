using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dibujo_de_circulo_y_cuadrado
{
    class Circulo : Figura
    {

        public int radio { set; get; }
        public Point centro { set; get; }

        public Circulo(int r, Point c)
        {
            radio = r;
            centro = c;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(radio, 2);

        }
       /* public override double AreaTotal()
        {
            return Math.PI * Math.Pow(radio,2);
        }*/
    }//fin de la clase 
}//fin del namespace
