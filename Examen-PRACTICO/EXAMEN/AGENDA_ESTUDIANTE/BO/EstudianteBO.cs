using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDA_ESTUDIANTE.BO
{
    class EstudianteBO
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        private string Correo;

        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string NOMBRE 
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string APELLIDO 
        { 
            set { apellido = value; }
            get { return apellido; }
        }
        public int EDAD 
        {
            set { edad = value; }
            get { return edad; }
        }
        public string CORREO 
        { 
            set { Correo = value; }
            get { return Correo; }
        }
    }
}
