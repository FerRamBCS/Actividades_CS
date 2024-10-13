using RBE_SV.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBE_SV
{
    class Central
    {    /*
         FUNCION CENTRAL: Inicializar logica para la base de datos
         */
        static string constrg = "Data Source=LAPTOP-FERNANDO\\fernando;" +
            "Initial Catalog=pos_RBE;User ID=sa;Password=123456;TrustServerCertificate=True";
        public static Response IniciarSesion(Usuarios usuarios)
        {
            /* Logica para Iniciar sesion */
            Response response = new Response();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("SELECT * FROM Usuarios WHERE nombre = @nombre AND contra = @contra", conn);
            comm.Parameters.AddWithValue("@nombre", usuarios.Usuario);
            comm.Parameters.AddWithValue("@contra", usuarios.Contra);
            try
            {
                conn.Open();
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    response.Codigo = 1;
                    response.Mensaje = "Inicio de sesión con éxito";
                }
                else
                {
                    response.Codigo = 2;
                    response.Mensaje = "Nombre de usuario o contraseña incorrectos";
                    ErrorLog.Log("Nombre de usuario o contraseña incorrectos", "IniciarSesion", "Central");
                }
            }
            catch (Exception ex)
            {
                response.Codigo = 2;
                response.Mensaje = "Error al intentar iniciar sesión";
                ErrorLog.Log(ex.Message, "IniciarSesion", "Central");
            }
            finally
            {
                conn.Close();
            }
            return response;

        }
    }
}
