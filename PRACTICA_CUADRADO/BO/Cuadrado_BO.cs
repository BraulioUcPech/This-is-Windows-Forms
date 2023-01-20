using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_CUADRADO.BO
{
    internal class Cuadrado_BO{

        private double lado, area;

        public Cuadrado_BO(double L){

            lado = L;

        }
        public double Cal_Area(){

            area = lado * lado;
            return area;

        }
    }
}
