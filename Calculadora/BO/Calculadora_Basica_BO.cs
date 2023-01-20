using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.BO{
    internal class Calculadora_Basica_BO{

        private double num1;
        private double num2;
        private double r_sum;
        private double r_res;
        private double r_mul;
        private double r_div;
        private double r_raiz;


        public Calculadora_Basica_BO(double N1, double N2){
            num1 = N1;
            num2 = N2;
        }



        public double Suma(){
            r_sum = num1 + num2;
            return r_sum;

        }
        public double Resta(){
            r_res = num1 - num2;
            return r_res;

        }
        public double Multiplicacion(){
            r_mul = num1 * num2;
            return r_mul;

        }
        public double Division(){
            r_div = num1 / num2;
            return r_div;

        }
        public double Raiz() {
            r_raiz = Math.Sqrt(num1 + num2);           
            return r_raiz;

        }
    }
}
