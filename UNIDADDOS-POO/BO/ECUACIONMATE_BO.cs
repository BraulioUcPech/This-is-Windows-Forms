using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UNIDADDOS_POO.BO{
    internal class ECUACIONMATE_BO{

        private double x, y, z, r;

        public double X{
            set { x = value; }
            get { return x; }
        }
        public double Y{
            set { y = value; }
            get { return y; }
        }
        public double Z{
            set { z = value; }
            get { return z; }
        }

        public double RESULTADO(){
            r = (Math.Sqrt(3 * Math.Pow(x, 4) + 2 * x * Math.Pow(y, 2) * z) + 5 * Math.Pow(x, 2) * y) / (3 + Math.Pow(x, 2) * Math.Pow(y, 2) * Math.Pow(z, 2));
            return r;

        }
    }
}
