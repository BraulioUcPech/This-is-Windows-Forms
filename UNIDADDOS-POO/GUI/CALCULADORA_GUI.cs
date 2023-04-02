using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIDADDOS_POO.BO;

namespace UNIDADDOS_POO.GUI
{
    public partial class CALCULADORA_GUI : Form
    {
        public CALCULADORA_GUI()
        {
            InitializeComponent();
        }

        private void rbtnSumar_CheckedChanged(object sender, EventArgs e){

            CALCULADORA_BO objsSuma = new CALCULADORA_BO();

            objsSuma.NUMERO1 = double.Parse(txtnumerouno.Text);
            objsSuma.NUMERO2 = double.Parse(txtnumerodos.Text);

            txtRespuesta.Text = objsSuma.SUMA().ToString();

        }

        private void rbtnMultiplicar_CheckedChanged(object sender, EventArgs e){

            CALCULADORA_BO objsMultiplicar = new CALCULADORA_BO();

            objsMultiplicar.NUMERO1 = double.Parse(txtnumerouno.Text);
            objsMultiplicar.NUMERO2 = double.Parse(txtnumerodos.Text);

            txtRespuesta.Text = objsMultiplicar.MULTIPLICAR().ToString();
        }

        private void rbtnResta_CheckedChanged(object sender, EventArgs e){

            CALCULADORA_BO objsResta = new CALCULADORA_BO();

            objsResta.NUMERO1 = double.Parse(txtnumerouno.Text);
            objsResta.NUMERO2 = double.Parse(txtnumerodos.Text);

            txtRespuesta.Text = objsResta.RESTA().ToString();

        }

        private void rbtnDividir_CheckedChanged(object sender, EventArgs e){
            CALCULADORA_BO objsDividir = new CALCULADORA_BO();

            objsDividir.NUMERO1 = double.Parse(txtnumerouno.Text);
            objsDividir.NUMERO2 = double.Parse(txtnumerodos.Text);

            txtRespuesta.Text = objsDividir.DIVIDIR().ToString();

        }
    }
}
