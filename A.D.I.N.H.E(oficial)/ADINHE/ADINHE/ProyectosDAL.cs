using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADINHE
{
    public class ProyectosDAL
    {

        public static int Agregar (Proyecto pProyecto)
        {
            using (SqlConnection sql = App.confi.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Proyecto (Proyectoid, Descricion, Usuariod) values ('{0}', '{1}','{2}')",
              pProyectoid.Proyectoid, pDsecripcion.Descipcion, pUsuariod.Usuariod), sql);

                retorno = Comando.ExecuteNonQuery();
                sql.Close();

            }
            return retorno;
        }

    }


    
}
