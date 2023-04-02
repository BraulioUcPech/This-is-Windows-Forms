using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DiseñodeInterfazdeUsuario.GUI;

namespace DiseñodeInterfazdeUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void practica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema_de_Ventas_GUI P1 = new Sistema_de_Ventas_GUI();

            //V.MdiParent = this;
            P1.Show();
        }

        private void practica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_de_pacientes_GUI P2 = new Registro_de_pacientes_GUI();

            P2.Show();
        }

        private void practica3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practica_cuadra_GUI P3 = new Practica_cuadra_GUI();
            P3.Show();
        }

        private void practica4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SumoMe_Login_GUI P4 = new SumoMe_Login_GUI();
            P4.Show();
        }

        private void practica5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practica_cinco_GUI P5 = new Practica_cinco_GUI();
            P5.Show();
        }

        private void diseñosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void practica6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edu_Facil_GUI P6 = new Edu_Facil_GUI();
            P6.Show();
        }

        private void practica7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes_GUI P7 = new Clientes_GUI();
            P7.Show();
        }
        
        
        
        //Las Ventanas de Login
        private void practica8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           User_Login_GUI P8= new User_Login_GUI();
           P8.Show();

        }

        private void practica9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn_To_Your_Account_GUI P9 = new LogIn_To_Your_Account_GUI();
            P9.Show();
        }

        private void practica10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Login_Parte_2_GUI P10 = new User_Login_Parte_2_GUI(); 
            P10.Show();
        }



        //DISEÑO ACTUAL EN EL MERCADO
        private void practica11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diseño_Actual_GUI P11 = new Diseño_Actual_GUI();
            P11.Show();
        }
    }
}
