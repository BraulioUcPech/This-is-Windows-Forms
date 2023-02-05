using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenciadevihiculos.BO{

    internal class Autobus_BO : RENTA_BO{

        public double PKiloM, KRenta, KDevuelta;


        public Autobus_BO(string P, double KM)
        {
            Placas = P;
            PKiloM = KM;
     
        }



        public override double Calculo(){

            Resultado = PKiloM * 2.02181295;
            return Resultado;
        }


    }
}
