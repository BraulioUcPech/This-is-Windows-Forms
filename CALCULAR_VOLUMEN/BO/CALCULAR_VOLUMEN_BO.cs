using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULAR_VOLUMEN.BO{

    internal class CALCULAR_VOLUMEN_BO{


        private double VEsfera, radio, VCubo, aristas, VCilindro, altura;


        public CALCULAR_VOLUMEN_BO(double R, double A, double H){

            radio = R;
            aristas = A;
            altura = H;
        }



        public double Cal_VEsfera(){

            VEsfera = (4.0/3.0) * Math.PI * (Math.Pow(radio, 3));
            return VEsfera;

        }
        public double Cal_VCubo(){

            VCubo = Math.Pow(aristas, 3);
            return VCubo;
        }
        public double Cal_VCilindro(){

            VCilindro = Math.PI * Math.Pow(radio, 2) * altura;
            return VCilindro;

        }

    }
}
