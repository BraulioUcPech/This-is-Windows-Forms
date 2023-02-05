using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _2parcial.BO;

namespace _2parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e){
            /*
            double R = double.Parse(textBox4.Text);

            CIRCUFERENCIA_BO obj_Circuferencia = new CIRCUFERENCIA_BO(R);

            textBox5.Text = obj_Circuferencia.CalcularArea().ToString();
            MessageBox.Show("El area Circuferencia " + obj_Circuferencia.resultado);

            double A = double.Parse(textBox2.Text);
            double L = double.Parse(textBox3.Text);
            */
        }

        private void button1_Click(object sender, EventArgs e){

          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e){      
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e){
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            double R = double.Parse(textBox4.Text);

            CIRCUFERENCIA_BO obj_Circuferencia = new CIRCUFERENCIA_BO(R);

            textBox5.Text = obj_Circuferencia.CalcularArea().ToString();
            MessageBox.Show("El area Circuferencia " + obj_Circuferencia.resultado);
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            double A = double.Parse(textBox2.Text);
            double L = double.Parse(textBox3.Text);

            RECTANGULO_BO obj_Rectangulo = new RECTANGULO_BO(A, L);

            textBox5.Text = obj_Rectangulo.CalcularArea().ToString();
            MessageBox.Show("El area Rectangulo " + obj_Rectangulo.resultado);
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            double B = double.Parse(textBox2.Text);
            double H = double.Parse(textBox1.Text);

            TRIANGULO_BO obj_Triangulo = new TRIANGULO_BO(B, H);

            textBox5.Text = obj_Triangulo.CalcularArea().ToString();
            MessageBox.Show("El area Triangulo " + obj_Triangulo.resultado);
        }
    }
}
