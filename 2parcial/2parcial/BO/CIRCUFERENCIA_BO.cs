using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2parcial.BO{
    internal class CIRCUFERENCIA_BO : FIGURA_BO{


        private double radio;

        public CIRCUFERENCIA_BO(double R){
            radio = R;

        }



        public override double CalcularArea(){

            resultado = Math.PI * Math.Pow(radio, 2);
            return resultado;
        }

    }
}
