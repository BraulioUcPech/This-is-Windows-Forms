using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURA_HERENCIAPOLIFORISMO.BO{
    internal class CIRCULO_BO : FIGURA_BO{

        private double Radio;

        public CIRCULO_BO(double R, string C){
            
            Radio = R;
            Color = C;
        }


        public override double Area(){

            Resultado = Math.PI * Math.Pow(Radio, 2);
            return Resultado;
        }

    }
}
