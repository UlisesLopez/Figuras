using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace dibujo_de_circulo_y_cuadrado
{
    class Vista
    {

        private Graphics g;
        private Color ColorLapiz, ColorFondo;//cambiar el color 
        private int anchura, altura;
        private Pen Lapiz;

        public Vista(Panel areaDibujo, Color cl, Color cf)
        {

            g = areaDibujo.CreateGraphics();
            ColorLapiz = cl;
            ColorFondo = cf;
            anchura = areaDibujo.Width;
            altura = areaDibujo.Height;

        }

        public void mostrar_rectangulo(Rectangulo r)
        {

            Lapiz = new Pen(ColorLapiz);
            Lapiz.Width = 3;
            g.DrawRectangle(Lapiz, r.P1.X, r.P1.Y, r.ancho(), r.alto());
        }


        public void mostrar_circulo(Circulo c)
        {

            Lapiz = new Pen(ColorLapiz);
            Lapiz.Width = 3;
            g.DrawEllipse(Lapiz, c.centro.X, c.centro.Y, c.radio, c.radio);

        }


        public void borrar()
        {
            SolidBrush fondo = new SolidBrush(Color.WhiteSmoke);
            Rectangle rect = new Rectangle(0, 0, anchura, altura);
            g.FillRectangle(fondo, rect);
        }


    }//fin de la clase
}//fin del namespace 
