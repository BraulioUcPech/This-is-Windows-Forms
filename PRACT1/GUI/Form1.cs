using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PRACT1.BO;

namespace PRACT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){
            //
            double VU = double.Parse(textBox1.Text);
            double CP = double.Parse(textBox2.Text);

            //Instancia de la Clase (Objeto) para pasar los datos
            TIENDA_PRODUCTO_BO Obj_ValorFinal = new TIENDA_PRODUCTO_BO(VU, CP);

            //Ejecutamos y mostramos resultado de la operación
            textBox3.Text = Obj_ValorFinal.Cal_Total().ToString();


        }
    }
}
