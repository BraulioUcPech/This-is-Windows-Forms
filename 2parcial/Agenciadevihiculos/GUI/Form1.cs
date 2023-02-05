using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agenciadevihiculos.BO;

namespace Agenciadevihiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){

            if(radioButton1.Checked == true){
                string P = textBox1.Text;
                double KM = double.Parse(textBox2.Text);
               

                Autobus_BO OBJ_autobus = new Autobus_BO(P, KM);

                textBox3.Text = OBJ_autobus.Calculo().ToString();
                OBJ_autobus.Calculo().ToString();

                string bus = "RENTA DE AUTOBÚS";
                MessageBox.Show("Placas: " + OBJ_autobus.Placas + "\n" +
                                "Precio por KM: $" + OBJ_autobus.PKiloM + "\n" +
                                "Kms. al rentar: " + OBJ_autobus.Resultado + "\n", bus);

                

               

                OBJ_autobus.Calculo().ToString();

                string bus1 = "RENTA DE AUTOBÚS";
                MessageBox.Show("Placas: " + OBJ_autobus.Placas + "\n" +
                                "Fecha de renta: " + dateTimePicker1.Text + "\n" +
                                "Precio por dia: $" + OBJ_autobus.Resultado + "\n", bus1);
            }
            else if(radioButton2.Checked == true){
                string P = textBox1.Text;
                double KM = double.Parse(textBox2.Text);

                Autobus_BO OBJ_autobus = new Autobus_BO(P, KM);
                Tractor_BO OBJ_tractor = new Tractor_BO(P);

                textBox3.Text = OBJ_tractor.Calculo().ToString();
                OBJ_tractor.Calculo().ToString();

                string trac = "RENTA DE AUTOBÚS";
                MessageBox.Show("Placas: " + OBJ_tractor.Placas + "\n" +
                                "Precio por KM: $" + OBJ_autobus.PKiloM + "\n" +
                                "Kms. al rentar: " + OBJ_tractor.Resultado + "\n", trac);

                


                OBJ_tractor.Calculo().ToString();

                string trac1 = "RENTA DE TRACTOR";
                MessageBox.Show("Placas: " + OBJ_tractor.Placas + "\n" +
                                "Fecha de renta: " + dateTimePicker1.Text + "\n" +
                                "Precio por dia: $" + OBJ_tractor.PDia + "\n", trac1);

            }

           

          

        }

        private void button2_Click(object sender, EventArgs e){
            if (radioButton1.Checked == true)
            {
                string P = textBox1.Text;

                Tractor_BO OBJ_autobus = new Tractor_BO(P);

                OBJ_autobus.Calculo().ToString();
                textBox4.Text = OBJ_autobus.Calculo().ToString();
                string bus = "DEVOLUCION DEL AUTOBÚS";
                MessageBox.Show("Placas: " + OBJ_autobus.Placas + "\n" +
                                "Fecha de devolucion: " + dateTimePicker1.Text + "\n" +
                                "Precio por dia: $" + OBJ_autobus.PDia + "\n", bus);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else if (radioButton2.Checked == true)
            {

                string P = textBox1.Text;

                Tractor_BO OBJ_tractor = new Tractor_BO(P);

                OBJ_tractor.Calculo().ToString();
                textBox4.Text = OBJ_tractor.Calculo().ToString();
                string trac = "DEVOLUCION DEL TRACTOR";
                MessageBox.Show("Placas: " + OBJ_tractor.Placas + "\n" +
                                "Fecha de devolucion: " + dateTimePicker1.Text + "\n" +
                                "Precio por dia: $" + OBJ_tractor.PDia + "\n", trac);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }


        }

        private void button3_Click(object sender, EventArgs e){
            Application.Exit();
        }





        private void radioButton1_CheckedChanged(object sender, EventArgs e){
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e){

        }
    }
}
