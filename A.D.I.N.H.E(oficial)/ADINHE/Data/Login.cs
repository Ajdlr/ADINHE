using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Data
{
    public class Login
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable LoginD(Entidades.Login obje)
        {
            SqlCommand cmd = new SqlCommand("dbo.splogin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", obje.descripcion);
            cmd.Parameters.AddWithValue("@contraseña", obje.contraseña);
            cmd.Parameters.AddWithValue("@rol", obje.rol);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable1 = new DataTable();
            da.Fill(dtable1);
            return dtable1; 
        }
    }
}
