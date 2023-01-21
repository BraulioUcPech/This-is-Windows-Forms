using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DISTANCIA_RECORRIDA.BO{


    internal class DISTANCIA_RECORRIDA_BO{

        private double M, MS, SG;


        public DISTANCIA_RECORRIDA_BO(double V, double S){
            MS = V;
            SG = S;

        }


        public double VELOCIDADCONST(){

            M = MS * SG;
            return M;

        }

    }
}
