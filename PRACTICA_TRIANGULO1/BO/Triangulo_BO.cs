using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_TRIANGULO1.BO{
    internal class Triangulo_BO{

        //Atributos
        private double Area;
        private double Base;
        private double Altura;

        //Constructor --> Pasar o pedir los datos en el interfaz
        public Triangulo_BO(double B, double A){

            Base = B;
            Altura = A;
        }

        //Metodo
        public double MArea(){

            Area = (Base * Altura) / 2;
            return Area;
        }

    }
}
