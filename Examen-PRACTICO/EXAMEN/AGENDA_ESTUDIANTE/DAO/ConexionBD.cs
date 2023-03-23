using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace AGENDA_ESTUDIANTE.DAO
{
    class ConexionBD
    {

        SqlConnection con;
        public SqlConnection establecerConexion()
        {
            string cs = "Data Source = BRAULIO\\SQLEXPRESS; Initial Catalog = examen2par; Integrated Security = true ";

            con = new SqlConnection(cs);
            return con;
        }
        public void abrirConexion()
        {
            con.Open();
        }
        public void cerrarConexion()
        {
            con.Close();
        }
    }
}
