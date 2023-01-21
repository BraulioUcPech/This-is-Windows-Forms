using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using DISTANCIA_RECORRIDA.BO;

namespace DISTANCIA_RECORRIDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){

            double V = double.Parse(textBox1.Text);
            double S = double.Parse(textBox2.Text);


            DISTANCIA_RECORRIDA_BO Obj_distancia = new DISTANCIA_RECORRIDA_BO(V, S);

            textBox3.Text = Obj_distancia.VELOCIDADCONST().ToString();
        }
    }
}
