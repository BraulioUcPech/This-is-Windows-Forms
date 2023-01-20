using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




//elabora una aplicacion de una calculadora basica que permita introduccir dos numeros y que calcule el resultado de la suma, resta, multiplicacion, division y raiz cuadrada de las suma de ambos numeros.
namespace Calculadora
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
