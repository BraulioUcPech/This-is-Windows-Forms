using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLEADO_SALARIO.BO{
    internal class EMPLEADO_SALARIO_BO{


        private double SalarioD, NumeroDT, Salario, DescuentoP, DescuentoS;


        public EMPLEADO_SALARIO_BO(double SD, double NT){

            SalarioD = SD;
            NumeroDT = NT;

        }




        public double PENSION(){

            Salario = (SalarioD * NumeroDT) * 0.10;
            DescuentoP = SalarioD - Salario;
            return DescuentoP;


        }

        public double SALUD(){

            Salario = (SalarioD * NumeroDT) * 0.15;
            DescuentoS = SalarioD - Salario;
            return DescuentoS;

        }







    }
}
