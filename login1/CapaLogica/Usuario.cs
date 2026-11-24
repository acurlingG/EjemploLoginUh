using login1.CapaDatos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace login1.CapaLogica
{
    public class Usuario
    {


        public static int  validausuario(string correo, string clave)
        {
                cls_usuario.correo= correo;
                cls_usuario.clave= clave;

            int resultado = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                using (SqlConnection conexion = new SqlConnection(connectionString))
                using (SqlCommand comando = new SqlCommand("SELECT correo, clave, nombre FROM usuarios WHERE correo = @correo AND clave = @clave", conexion))
                {
                    // Usar parámetros evita inyección SQL
                    comando.Parameters.AddWithValue("@correo", cls_usuario.correo);
                    comando.Parameters.AddWithValue("@clave", cls_usuario.clave);

                    conexion.Open();
                    using (SqlDataReader registro = comando.ExecuteReader())
                    {
                        if (registro.Read())
                        {
                            cls_usuario.nombre = registro["nombre"].ToString();
                            return resultado = 1;
                        }
                        else
                        {
                            return resultado = 0;
                        }
                    }
                }
            }
            catch (Exception)
            {

                return resultado = 0;
            }

    }



}
}