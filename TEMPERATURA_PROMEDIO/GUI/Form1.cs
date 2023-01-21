using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TEMPERATURA_PROMEDIO.BO;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TEMPERATURA_PROMEDIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            double D1 = double.Parse(textBox1.Text);
            double D2 = double.Parse(textBox2.Text);
            double D3 = double.Parse(textBox3.Text);
            double D4 = double.Parse(textBox4.Text);
            double D5 = double.Parse(textBox5.Text);
            double D6 = double.Parse(textBox6.Text);
            double D7 = double.Parse(textBox7.Text);

            TEMPERATURA_PROMEDIO_BO Obj_ValorFinal = new TEMPERATURA_PROMEDIO_BO(D1, D2, D3, D4, D5, D6, D7);

            textBox8.Text = Obj_ValorFinal.PROMEDIO_TEM().ToString();
      

        }
    }
}
