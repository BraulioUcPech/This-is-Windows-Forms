using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADDOS_POO.BO{
    internal class SUELDONETO_BO{

        private double Sueldo, Incentivo, Bonificacion, PagoTotal, Porcentaje;

        public double SUELDO{
            set{

                Sueldo = value;

            }
            get{

                return Sueldo;
            }
        }
        public double INCENTIVO{
            set{
                Incentivo = value;
            }
            get{
                return Incentivo;
            }
        }
        public double BONIFICACION{
            set{
                Bonificacion = value;
            }
            get{
                return Bonificacion;
            }
        }
        public double TOTAL(){

            Porcentaje = (Sueldo + Incentivo) * (Bonificacion/100);
            PagoTotal = Sueldo + Incentivo + Porcentaje;
            return PagoTotal;


        }

    }
}
