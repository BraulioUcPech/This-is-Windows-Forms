using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referencia a la Clase Bo
using PRACTICA_TRIANGULO1.BO;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRACTICA_TRIANGULO1{
    public partial class Form1 : Form{
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e){
            //
            double B = double.Parse(textBox1.Text);
            double A = double.Parse(textBox2.Text);

            //Instancia de la Clase (Objeto) para pasar los datos
            Triangulo_BO Obj_triangulo = new Triangulo_BO(B, A);

            //Ejecutamos y mostramos resultado de la operación
            textBox3.Text = Obj_triangulo.MArea().ToString();

        }
    }
}
