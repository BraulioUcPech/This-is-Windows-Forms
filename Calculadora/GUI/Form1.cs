using Calculadora.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Calculadora.BO;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){

            //Obtener los datos del textbox para las variables
            double N1 = double.Parse(textBox1.Text);
            double N2 = double.Parse(textBox2.Text);
             
            //Instancia de la Clase (Objeto) para pasar los datos
            Calculadora_Basica_BO Obj_Cal = new Calculadora_Basica_BO(N1, N2);

            //Ejecutamos y mostramos resultado de la operación
            textBox3.Text = Obj_Cal.Suma().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e){
            
            double N1 = double.Parse(textBox1.Text);
            double N2 = double.Parse(textBox2.Text);

            Calculadora_Basica_BO Obj_Cal = new Calculadora_Basica_BO(N1, N2);

            textBox3.Text = Obj_Cal.Resta().ToString();

        }

        private void button3_Click(object sender, EventArgs e){

            double N1 = double.Parse(textBox1.Text);
            double N2 = double.Parse(textBox2.Text);

            Calculadora_Basica_BO Obj_Cal = new Calculadora_Basica_BO(N1, N2);

            textBox3.Text = Obj_Cal.Division().ToString();
        }

        private void button4_Click(object sender, EventArgs e){

            double N1 = double.Parse(textBox1.Text);
            double N2 = double.Parse(textBox2.Text);

            Calculadora_Basica_BO Obj_Cal = new Calculadora_Basica_BO(N1, N2);

            textBox3.Text = Obj_Cal.Multiplicacion().ToString();

        }

        private void button5_Click(object sender, EventArgs e){

            double N1 = double.Parse(textBox1.Text);
            double N2 = double.Parse(textBox2.Text);

            Calculadora_Basica_BO Obj_Cal = new Calculadora_Basica_BO(N1, N2);

            textBox3.Text = Obj_Cal.Raiz().ToString();

        }

        private void button6_Click(object sender, EventArgs e){

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
