using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADINHE.CAPACONEXION
{
    class ClsProductos
    {

        private ConecionBD Conexion = new ConecionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarUsuario()
        {
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = " ListarUsuario";
                Comando.CommandType = CommandType.StoredProcedure;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
        }

       

        public void InsertarRegistro(int Usuarioid, string descripcion, string contraseña, int rol)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarRegistro";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@usuarioid", int Usuarioid);
            Comando.Parameters.AddWithValue("@descripcion", string descripcion);
            Comando.Parameters.AddWithValue("@contraseña", string contraseña);
            Comando.Parameters.AddWithValue("@rol", int rol);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public void InsertarProyecto( int usuario_usuarioid, string descripcion, int proyectoid)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarProyecto";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@proyectoid", int proyectoid);
            Comando.Parameters.AddWithValue("@descripcion", string descripcion);
            Comando.Parameters.AddWithValue("@usuario_usuarioid", int usuario_usuarioid);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }
        public DataTable ListarProyecto_M()
        {
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ListarProyecto_M";
                Comando.CommandType = CommandType.StoredProcedure;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
        }

        public void EliminarProyecto(int usuario_usuarioid, string descripcion, int proyectoid)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "EliminarProyecto";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@proyectoid", int proyectoid);
            Comando.Parameters.AddWithValue("@descripcion", string descripcion);
            Comando.Parameters.AddWithValue("@usuario_usuarioid", int usuario_usuarioid);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }


    }
}