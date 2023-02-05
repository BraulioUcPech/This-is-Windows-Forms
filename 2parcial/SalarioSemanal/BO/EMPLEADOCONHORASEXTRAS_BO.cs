using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioSemanal.BO{
    internal class EMPLEADOCONHORASEXTRAS_BO : EMPLEADO_BO{

        public int horasExtras;

        public EMPLEADOCONHORASEXTRAS_BO(int HT, double SH)
        {
            horastrabajadas = HT;
            sueldoporhora = SH;
        }

        public override double CalcularSalaio(){

            if (horastrabajadas > 41 && horastrabajadas <= 45){

                horasExtras = horastrabajadas - 40;
                salario = (40 * sueldoporhora) + (horasExtras * sueldoporhora * 2);

            }


            return salario;
        }


    }
}
