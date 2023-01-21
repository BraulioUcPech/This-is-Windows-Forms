using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMPERATURA_PROMEDIO.BO{
    internal class TEMPERATURA_PROMEDIO_BO{


        private double Dia1, Dia2, Dia3, Dia4, Dia5, Dia6, Dia7, Promedio;
        


        public TEMPERATURA_PROMEDIO_BO(double D1, double D2, double D3, double D4, double D5, double D6, double D7 ){
            Dia1 = D1;
            Dia2 = D2;
            Dia3 = D3;
            Dia4 = D4;
            Dia5 = D5;
            Dia6 = D6;
            Dia7 = D7;

        }


    public double PROMEDIO_TEM(){

            Promedio = (Dia1 + Dia2 + Dia3 + Dia4 + Dia5 + Dia6 + Dia7) / 7;

            return Promedio;

            

        }



    }
}

