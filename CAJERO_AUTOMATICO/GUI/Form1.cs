using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CAJERO_AUTOMATICO.BO;

namespace CAJERO_AUTOMATICO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            int B1, B10, B50, B100, B200, B1000;
            int Dinero;

            Dinero = Convert.ToInt32(textBox1.Text);

            B1000 = Dinero / 1000;
            Dinero = Dinero % 1000;

            B200 = Dinero / 200;
            Dinero = Dinero % 200;

            B100 = Dinero / 100;
            Dinero = Dinero % 100;

            B50 = Dinero / 50;
            Dinero = Dinero % 50;

            B10 = Dinero / 10;
            Dinero = Dinero % 10;

            B1 = Dinero / 1;
            Dinero = Dinero % 1;

            textBox2.Text = B1.ToString();
            textBox3.Text = B10.ToString();
            textBox4.Text = B50.ToString();
            textBox5.Text = B100.ToString();
            textBox6.Text = B200.ToString();
            textBox7.Text = B1000.ToString();

            /*int D = int.Parse(textBox1.Text);


            CAJERO_AUTOMATICO_BO Obj_convertir = new CAJERO_AUTOMATICO_BO(D);


            textBox2.Text = Obj_convertir.UNPESO().ToString();
            textBox3.Text = Obj_convertir.DIEZ().ToString();
            textBox4.Text = Obj_convertir.CINCUENTA().ToString();
            textBox5.Text = Obj_convertir.CIEN().ToString();
            textBox6.Text = Obj_convertir.DOSCIENTOS().ToString();
            textBox7.Text = Obj_convertir.MIL().ToString();*/

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) {
            string texto = textBox1.Text;
            texto = texto.Substring(0, texto.Count() - 1);
            textBox1.Text = texto   ;



        }

        private void button3_Click(object sender, EventArgs e){

            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
         
        }
    }
}
