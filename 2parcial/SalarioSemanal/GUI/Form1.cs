using SalarioSemanal.BO;
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



namespace SalarioSemanal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {



            int TH = int.Parse(textBox1.Text);
            double SH = double.Parse(textBox2.Text);

            EMPLEADOSINHORASAEXTRAS_BO OBJ_SINHORAS = new EMPLEADOSINHORASAEXTRAS_BO(TH, SH);

            OBJ_SINHORAS.CalcularSalaio().ToString();

            string sinhoras = "Empleado sin horas extras";
            MessageBox.Show("Horas trabajadas: $" + OBJ_SINHORAS.horastrabajadas + "\n" +
                            "Sueldo por horas: $" + OBJ_SINHORAS.sueldoporhora + "\n" +
                            "Salario: $" + OBJ_SINHORAS.salario + "\n", sinhoras);




            EMPLEADOCONHORASEXTRAS_BO OBJ_DOBLES = new EMPLEADOCONHORASEXTRAS_BO(TH, SH);

            OBJ_DOBLES.CalcularSalaio().ToString();

            string porhoras = "Empleado con horas dobles";
            MessageBox.Show("Horas trabajadas: $" + OBJ_DOBLES.horastrabajadas + "\n" +
                            "Sueldo por horas: $" + OBJ_DOBLES.sueldoporhora + "\n" +
                            "Horas extras: $" + OBJ_DOBLES.horasExtras + "\n" +
                            "Salario: $" + OBJ_DOBLES.salario + "\n", porhoras);



            EMPLEADOCONHORASTRIPLES_BO OBJ_TIPLES = new EMPLEADOCONHORASTRIPLES_BO(TH, SH);

            OBJ_TIPLES.CalcularSalaio().ToString();

            string horastriples = "Empleado con horas triples";
            MessageBox.Show("Horas trabajadas: $" + OBJ_TIPLES.horastrabajadas + "\n" +
                            "Sueldo por horas: $" + OBJ_TIPLES.sueldoporhora + "\n" +
                            "Horas extras: $" + OBJ_TIPLES.horasExtras + "\n" +
                            "Salario: $" + OBJ_TIPLES.salario + "\n", horastriples);
        }
    }
}
