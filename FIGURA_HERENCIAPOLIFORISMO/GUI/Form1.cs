using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FIGURA_HERENCIAPOLIFORISMO.BO;

namespace FIGURA_HERENCIAPOLIFORISMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){

            double L = double.Parse(textBox2.Text);
            string C = textBox1.Text;


            CUADRADO_BO obj_Cuadrado = new CUADRADO_BO(L, C);

            textBox4.Text = obj_Cuadrado.Area().ToString();

            MessageBox.Show("El color del cuadrado es " + obj_Cuadrado.Color);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double L = double.Parse(textBox3.Text);
            string R = textBox1.Text;


            CUADRADO_BO obj_Radio = new CUADRADO_BO(L, R);

            textBox4.Text = obj_Radio.Area().ToString();

            MessageBox.Show("El color del cuadrado es " + obj_Radio.Color);
        }
    }
}
