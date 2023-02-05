using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioSemanal.BO {
    internal class EMPLEADOCONHORASTRIPLES_BO : EMPLEADO_BO{

        public double horasExtras;


        public EMPLEADOCONHORASTRIPLES_BO(int HT, double SH)
        {
            horastrabajadas = HT;
            sueldoporhora = SH;
        }



        public override double CalcularSalaio() {


            if (horastrabajadas > 45)
            {
                horasExtras = horastrabajadas - 40;
                salario = (40 * sueldoporhora) + (horasExtras * sueldoporhora * 3);
            }

            return salario;
        }

    }
}
