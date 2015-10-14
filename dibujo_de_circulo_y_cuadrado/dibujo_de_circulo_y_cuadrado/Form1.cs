using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//para la clase Thread se agrega system.threading 

namespace dibujo_de_circulo_y_cuadrado
{
    public partial class Form1 : Form
    {
        Rectangulo r;
        Vista v;
        Circulo c;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordenada.Text = string.Format("({0},{1})", e.X, e.Y);
        }

        private void lbCoordenada_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (radioButton1Rec.Checked)
            {
                textBox1Xp1.Text = e.X.ToString();
                textBox2Yp1.Text = e.Y.ToString();
            }
            else
            {
                textBox5px.Text = e.X.ToString();
                textBox7py.Text = e.Y.ToString();
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1Rec.Checked)
            {
                textBox3Xp2re.Text = e.X.ToString();
                textBox4Yp2re.Text = e.Y.ToString();
                calcularArea();
                Dibujar();
            }
            else
            {
                if (radioButton2Circ.Checked)
                {
                    textBox5px.Text = e.X.ToString();
                    textBox7py.Text = e.Y.ToString();
                    textBox6Radio.Text = (Math.Abs(int.Parse(textBox5px.Text) + e.X)).ToString();
                    calcularArea();
                    Dibujar();
                }
            }
        }

        public void calcularArea()
        {
            if (radioButton1Rec.Checked)
            {
                Point punto1 = new Point(int.Parse(textBox1Xp1re.Text), int.Parse(textBox2Yp1re.Text));
                Point punto2 = new Point(int.Parse(textBox3Xp2re.Text), int.Parse(textBox4Yp2re.Text));
                r = new Rectangulo(punto1, punto2);
                totrecta.Text = r.area().ToString();
            }
            else
            {
                Point puntoCirculo = new Point(int.Parse(textBox5px.Text),int.Parse(textBox7py.Text));
                int radio = int.Parse(textBox6Radio.Text);
                c = new Circulo(radio, puntoCirculo);
                totalCirculo.Text = c.area().ToString();
            }
        }

        private void button2dibuj_Click(object sender, EventArgs e)
        {
            Dibujar();

        }


        public void Dibujar()
        {
            v = new Vista(panel1, Color.Blue, Color.White);
            if (radioButton1Rec.Checked)
            {
                v.mostrar_rectangulo(r);
            }
            else
            {
                if (radioButton2Circ.Checked)
                {
                    v.mostrar_circulo(c);
                }
            }

        }

        private void button1Calcu_Click(object sender, EventArgs e)
        {
            calcularArea();
        }

        private void button3Borr_Click(object sender, EventArgs e)
        {
            v.borrar();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1Rec.AutoCheck)
            {
                textBox1Xp1re.Text = e.X.ToString();
                textBox2Yp1re.Text = e.Y.ToString();
            }
            else
            {
                textBox5px.Text = e.X.ToString();
                textBox7py.Text = e.Y.ToString();
            }
        }
    }
}
