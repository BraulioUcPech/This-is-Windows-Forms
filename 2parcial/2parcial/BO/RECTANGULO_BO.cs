using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2parcial.BO{
    internal class RECTANGULO_BO : FIGURA_BO{

        private double largo, ancho;


        public RECTANGULO_BO(double L, double A){
            largo = L;
            ancho = A;
        }


        public override double CalcularArea(){

            resultado = largo * ancho;
            return resultado;
        }

    }
}
