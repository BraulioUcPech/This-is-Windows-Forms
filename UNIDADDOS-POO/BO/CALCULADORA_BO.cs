using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADDOS_POO.BO{
    internal class CALCULADORA_BO{

        private double num1, num2, resultado;

        public double NUMERO1{

            set { num1 = value; }
            get { return num1; }
        }
        public double NUMERO2{

            set { num2 = value; }
            get { return num2; }

        }
        public double SUMA(){

            resultado = num1 + num2;
            return resultado;
        }
        public double RESTA(){
            resultado = num1 - num2;
            return resultado;
        }
        public double DIVIDIR(){
            resultado = num1 / num2;
            return resultado;
        }
        public double MULTIPLICAR(){
            resultado = num1 * num2;
            return resultado;
        }

    }
}
