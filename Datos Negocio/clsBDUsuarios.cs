using Entidades_Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Negocio
{
    public class clsBDUsuarios
    {
        clsConexionDB conexion =new clsConexionDB();
        public void Guardar(clsBEUsuarios objBEUsuarios)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "spUsuarios_Guardar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", objBEUsuarios.Nombre);
            comando.Parameters.AddWithValue("@Edad", objBEUsuarios.Edad);
            comando.Parameters.AddWithValue("@Correo", objBEUsuarios.Correo);
            comando.Parameters.AddWithValue("@Iglesia", objBEUsuarios.Iglesia);
            comando.Parameters.AddWithValue("@Pais", objBEUsuarios.Pais);
            comando.Parameters.AddWithValue("@Departamento", objBEUsuarios.Departamento);
            comando.Parameters.AddWithValue("@Municipio", objBEUsuarios.Municipio);
            comando.Parameters.AddWithValue("@Barrio", objBEUsuarios.Barrio);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
