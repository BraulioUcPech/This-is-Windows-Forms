using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioSemanal.BO{

    internal class EMPLEADOSINHORASAEXTRAS_BO : EMPLEADO_BO{

        public EMPLEADOSINHORASAEXTRAS_BO(int HT, double SH)
        {
            horastrabajadas = HT;
            sueldoporhora = SH;
        }

        public override double CalcularSalaio(){

            if (horastrabajadas <= 40)
            {

                salario = horastrabajadas * sueldoporhora;

            }



            return salario;
        }

    }
}
