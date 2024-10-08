using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Logger
    {
        static string constrg = "Data Source=LAPTOP-FERNANDO\\fernando;" +
             "Initial Catalog=Calificaciones;User ID=sa;Password=123456;TrustServerCertificate=True";

        public static void Log(string mensaje, string metodo, string clase)
        {
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("insert into LogError (mensaje,metodo,clase,fecha)" +
                "values(@mensaje,@metodo,@clase,@fecha) ", conn);
            comm.Parameters.AddWithValue("@mensaje", mensaje);
            comm.Parameters.AddWithValue("@metodo", metodo);
            comm.Parameters.AddWithValue("@clase", clase);
            comm.Parameters.AddWithValue("@fecha", DateTime.Now);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
