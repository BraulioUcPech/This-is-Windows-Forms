using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURA_HERENCIAPOLIFORISMO.BO{
    internal class CUADRADO_BO : FIGURA_BO {

        private double Lado;

        public CUADRADO_BO(double L, string C){

            Lado = L;
            Color = C;

        }

        public override double Area() {

            Resultado = (Lado * Lado);

            return Resultado;
        }




    }
}
