using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2parcial.BO{
    internal class TRIANGULO_BO : FIGURA_BO{
        private double altura, Base;

        public TRIANGULO_BO(double H, double B){

            altura = H;
            Base = B;

        }

        public override double CalcularArea(){

            resultado = (altura * Base) / 2;

            return resultado;
        }
    }
}
