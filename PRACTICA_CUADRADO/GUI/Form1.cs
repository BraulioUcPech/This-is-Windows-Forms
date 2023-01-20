using PRACTICA_CUADRADO.BO;
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

namespace PRACTICA_CUADRADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtener los datos del textbox para las variables
            double L = double.Parse(textBox1.Text);

            //Instancia de la Clase (Objeto) para pasar los datos
            Cuadrado_BO Obj_Cuadrado = new Cuadrado_BO(L);

            //Ejecutamos y mostramos resultado de la operación
            textBox2.Text = Obj_Cuadrado.Cal_Area().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
