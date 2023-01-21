using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERTIR_GRADOS.BO{



    internal class CONVERTIR_GRADOS_BO{

        private double Centi, Fahren, Kelvin, Rankine;

        public CONVERTIR_GRADOS_BO(double C){
            Centi = C;
 

        }

        public double CELFAH(){

            Fahren = Centi * 9 / 5 + 32;     

            return Fahren;
        }
        public double CELKEL(){
            Kelvin = Centi + 273.15;
            return Kelvin;


        }
        public double CELRAN(){
            Rankine = Centi * 9 / 5 + 491.67;
            return Rankine;

        }
        public double FAHCEL(){
            Centi = (Fahren - 32) * 5 / 9;
            return Centi;
        }
        public double FAHKEL(){
            Kelvin = (Fahren + 459.670) * 5 / 9;
            return Kelvin;
        }
        public double FAHRAN(){
            Rankine = Fahren + 459.67;
            return Rankine;
        }


    }
}
