using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADINHE.CAPACONEXION
{
    class ConecionBD
    {
        static private string CadenaConexion = "Server=DESKTOP-9H2KUUA\MSSQLSERVER03 , DataBase=ADINHE2; Integrated Security=True";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {

            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {

            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }        
    }
}
