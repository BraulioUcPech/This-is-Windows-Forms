using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using CONVERTIR_GRADOS.BO;

namespace CONVERTIR_GRADOS
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

        private void button1_Click(object sender, EventArgs e){

            double C = double.Parse(textBox1.Text);
        

            CONVERTIR_GRADOS_BO Obj_convertir = new CONVERTIR_GRADOS_BO(C);

            textBox2.Text = Obj_convertir.CELFAH().ToString();
            textBox3.Text = Obj_convertir.FAHKEL().ToString();
            textBox4.Text = Obj_convertir.CELRAN().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
