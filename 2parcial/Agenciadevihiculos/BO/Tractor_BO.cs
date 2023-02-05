using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenciadevihiculos.BO{
    internal class Tractor_BO : RENTA_BO{

        public double PDia;


        public Tractor_BO(string P)
        {
            Placas = P;
        }

        public override double Calculo(){

            PDia = 32.50;

            return PDia;
        }


    }
}
