using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACT1.BO{
    internal class TIENDA_PRODUCTO_BO{

        private double VUnitario, CProductos, VFinal, IVA;


        public TIENDA_PRODUCTO_BO(double VU, double CP){

            VUnitario = VU;
            CProductos = CP;
        }


        public double Cal_Total(){

            IVA = (VUnitario * CProductos) * 0.16;
            VFinal = VUnitario + IVA;
            return VFinal;


        } 

    }
}
