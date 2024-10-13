using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBE_SV
{
    internal class ErrorLog
    {
        static string constrg = "Data Source=LAPTOP-FERNANDO\\fernando;" +
            "Initial Catalog=pos_RBE;User ID=sa;Password=123456;TrustServerCertificate=True";

        public static void Log(string mensaje, string metodo, string clase)
        {
            using (SqlConnection conn = new SqlConnection(constrg))
            {
                using (SqlCommand comm = new SqlCommand("INSERT INTO LogError (mensaje, metodo, clase, fecha) VALUES (@mensaje, @metodo, @clase, @fecha)", conn))
                {
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
                        Console.WriteLine("Error al registrar el log: " + ex.Message);
                    }
                }
            }
        }
    }
}
