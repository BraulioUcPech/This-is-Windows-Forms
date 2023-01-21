using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CALCULAR_VOLUMEN.BO;

namespace CALCULAR_VOLUMEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

            double R = double.Parse(textBox1.Text);
            double H = double.Parse(textBox2.Text);
            double A = double.Parse(textBox3.Text);


            CALCULAR_VOLUMEN_BO Obj_Esfera = new CALCULAR_VOLUMEN_BO(R, H, A);

            textBox4.Text = Obj_Esfera.Cal_VEsfera().ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e){

            double R = double.Parse(textBox1.Text);
            double H = double.Parse(textBox2.Text);
            double A = double.Parse(textBox3.Text);


            CALCULAR_VOLUMEN_BO Obj_Cubo = new CALCULAR_VOLUMEN_BO(R, H, A);

            textBox4.Text = Obj_Cubo.Cal_VCubo().ToString();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e){
            double R = double.Parse(textBox1.Text);
            double H = double.Parse(textBox2.Text);
            double A = double.Parse(textBox3.Text);


            CALCULAR_VOLUMEN_BO Obj_Cilindro = new CALCULAR_VOLUMEN_BO(R, H, A);

            textBox4.Text = Obj_Cilindro.Cal_VCilindro().ToString();

        }
    }
}
