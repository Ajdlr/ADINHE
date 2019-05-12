using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Ap_escuela
{
    class UsuarioDAL
    {

        public static int CrearCuentas(string pUsuario, string pContraseña)
        {
            int resultado = 0;
            SqlConnection sql = App.confi.ObtnerCOnexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuarios (Descripcion, Contraseña, Rol) values ('{0}', PwdEncrypt('{1}'), '{2}´' )", pDescripcion, pContraseña, pRol), sql);

            resultado = Comando.ExecuteNonQuery();
            sql.Close();

            return resultado;
        }



        public static int Autentificar(String pUsuarios, String pContraseña)
        {
            int resultado = -1;

            SqlConnection conexion = App.confi.ObtnerCOnexion();

            SqlCommand comando = new SqlCommand(string.Format(
                "Select * From Usuarios Where Nombre = '{0}' and PwdCompare('{1}',Contraseña) = 1 ", pUsuarios, pContraseña), conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }

            conexion.Close();
            return resultado;
        }



    }
}