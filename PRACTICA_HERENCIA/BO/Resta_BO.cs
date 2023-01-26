using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_HERENCIA.BO
{
    internal class Resta_BO : Operacion_BO{



        public double Resta()
        {
            Res = Num1 - Num2;
            return Res;
        }
    }
}
