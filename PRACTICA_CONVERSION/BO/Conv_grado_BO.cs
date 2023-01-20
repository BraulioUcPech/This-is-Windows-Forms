using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_CONVERSION.BO{
    internal class Conv_grado_BO{
        //Atributos
        private double num;
        private double r_f;
        private double r_c;


        //Constructor
        public Conv_grado_BO(double N){

            num = N;

        }
        

        //Métodos
        public double GradoF(){

            r_f = (num * 1.8) + 32;
            return r_f;

        }
        public double GradoC(){

            r_c = (num - 32) / 1.8;
            return r_c;

        }


    }
}
