using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using AGENDA_ESTUDIANTE.BO;

namespace AGENDA_ESTUDIANTE.DAO
{
    class EstudianteDAO
    {
        ConexionBD con = new ConexionBD();
        SqlCommand cmd = new SqlCommand();

        string sql;
        public bool Guardar(EstudianteBO ObjPersona)
        {
            EstudianteBO datos = (EstudianteBO) ObjPersona;
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();
            sql = "Insert into Estudiantes ([Nombre], [Apellidos], [Edad], [CorreoElectronico]) values('" + datos.NOMBRE + "', '" + datos.APELLIDO + "', '" + datos.EDAD + "', '" + datos.CORREO + "')";

            cmd.CommandText = sql;
            int folio = cmd.ExecuteNonQuery();
            con.cerrarConexion();
            if (folio <= 0)
            {
                return false;
            }
            return true;
        }


        public bool Elimianr(EstudianteBO ObjPersona)
        {
            EstudianteBO datos = (EstudianteBO) ObjPersona;
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            sql = "delete from Estudiantes where ID = '" + datos.ID + "'";
            cmd.CommandText = sql;

            int folio = cmd.ExecuteNonQuery();
            con.cerrarConexion();
            if (folio <= 0)
            {
                return false;
            }
            return true;
        }

        public bool Actualizar(EstudianteBO ObjPersona)
        {
            EstudianteBO datos = (EstudianteBO)ObjPersona;
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            sql = "Update Estudiantes set Nombre='" + datos.NOMBRE + "' , Apellidos='" +  datos.APELLIDO + "', Edad='" + datos.EDAD + "', CorreoElectronico = '" +datos.CORREO + "'where ID='" + datos.ID +  "' ";
            cmd.CommandText = sql;
            int folio = cmd.ExecuteNonQuery();
            con.cerrarConexion();
            if (folio <= 0)
            {
                return false;
            }
            return true;
        }

        public DataTable TablaEstudiante ()
        {

            sql = "Select * from Estudiantes"; 
            SqlDataAdapter adp = new SqlDataAdapter(sql, con.establecerConexion());
            DataTable tablavirutal = new DataTable();
            adp.Fill(tablavirutal);
            return tablavirutal;
        }


    }
}
