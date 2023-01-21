using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EMPLEADO_SALARIO.BO;


namespace EMPLEADO_SALARIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //
            double SD = double.Parse(textBox1.Text);
            double NT = double.Parse(textBox2.Text);

            //Instancia de la Clase (Objeto) para pasar los datos
            EMPLEADO_SALARIO_BO Obj_Pension = new EMPLEADO_SALARIO_BO(SD, NT);

            //Ejecutamos y mostramos resultado de la operación
            textBox3.Text = Obj_Pension.PENSION().ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e){
            double SD = double.Parse(textBox1.Text);
            double NT = double.Parse(textBox2.Text);

            EMPLEADO_SALARIO_BO Obj_Salud = new EMPLEADO_SALARIO_BO(SD, NT);

    
            textBox3.Text = Obj_Salud.SALUD().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
