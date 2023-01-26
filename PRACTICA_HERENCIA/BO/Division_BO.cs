using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_HERENCIA.BO{
    internal class Division_BO : Operacion_BO{


        public double Division(){
            Res = Num1 / Num2;
            return Res;
        }
    }
}
