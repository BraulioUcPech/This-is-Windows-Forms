using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UNIDADDOS_POO.GUI;

namespace UNIDADDOS_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void juegosToolStripMenuItem_Click(object sender, EventArgs e){
            CALCULADORA_GUI V4 = new CALCULADORA_GUI();

            
            V4.Show();
        }

        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculoDeSueldoToolStripMenuItem_Click(object sender, EventArgs e){

            SueldoNeto_GUI V1 = new SueldoNeto_GUI();

            
            V1.Show();

        }

        private void pianoToolStripMenuItem_Click(object sender, EventArgs e){
            LIBROS_GUI V2 = new LIBROS_GUI();

            
            V2.Show();
        }

        private void ventaDeLibrosToolStripMenuItem_Click(object sender, EventArgs e){
            ECUACIONMATE_GUI V3 = new ECUACIONMATE_GUI();

           
            V3.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e){
            SELECCIONDELIBROS_GUI V5 = new SELECCIONDELIBROS_GUI();

            
            V5.Show();

        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e){

            DADOS_GUI V6 = new DADOS_GUI();

            
            V6.Show();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e){

            PRODUCTOYAPAREZCA_GUI V7 = new PRODUCTOYAPAREZCA_GUI();

            
            V7.Show();
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e){

            GATO_GUI V8 = new GATO_GUI();

           
            V8.Show();

        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e){

            CARTAS_GUI V9 = new CARTAS_GUI();

            
            V9.Show();

        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e){

            PIANO_GUI V10 = new PIANO_GUI();

            
            V10.Show();

        }
    }
}
