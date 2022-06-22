using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos_Negocio
{
     class clsConexionDB
    {
        SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS ; database=Talento VPN ; integrated security = true");

        public SqlConnection abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

                return conexion;
        }

        public SqlConnection cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
                return conexion;

        }
    }
}
