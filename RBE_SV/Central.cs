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
        public static string ObtenerNombreUsuario(string nombreUsuario, string contraseña)
        {
            string nombreCompleto = string.Empty;

            using (SqlConnection conn = new SqlConnection(constrg))
            {
                conn.Open();

                // Consulta SQL para verificar el nombre de usuario y la contraseña
                string query = "SELECT NombreCompleto FROM Usuarios WHERE Usuario = @Usuario AND Contra = @Contra";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contra", contraseña);

                // Ejecutar la consulta
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Si encuentra el usuario, extrae el nombre completo
                    nombreCompleto = reader["NombreCompleto"].ToString();
                }
                else
                {
                    throw new Exception("Usuario o contraseña incorrectos.");
                }
            }

            return nombreCompleto;
        }

        public static void RegistrarVenta(Venta venta)
        {
            using (SqlConnection conn = new SqlConnection(constrg))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insertar la venta en la tabla Venta
                        SqlCommand cmdVenta = new SqlCommand(
                            "INSERT INTO Venta (Folio, NombreCliente, NumeroContacto, DetallesDomicilio, FechaVenta, EstadoPago, Total) " +
                            "VALUES (@Folio, @NombreCliente, @NumeroContacto, @DetallesDomicilio, @FechaVenta, @EstadoPago, @Total)",
                            conn, transaction);

                        cmdVenta.Parameters.AddWithValue("@Folio", venta.Folio);
                        cmdVenta.Parameters.AddWithValue("@NombreCliente", venta.NombreCliente);
                        cmdVenta.Parameters.AddWithValue("@NumeroContacto", venta.NumeroContacto);
                        cmdVenta.Parameters.AddWithValue("@DetallesDomicilio", venta.DetallesDomicilio);
                        cmdVenta.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta);
                        cmdVenta.Parameters.AddWithValue("@EstadoPago", venta.EstadoPago);
                        cmdVenta.Parameters.AddWithValue("@Total", venta.Total);

                        cmdVenta.ExecuteNonQuery();

                        // Obtener el ID de la venta recién insertada
                        SqlCommand cmdGetId = new SqlCommand("SELECT SCOPE_IDENTITY()", conn, transaction);
                        int ventaId = Convert.ToInt32(cmdGetId.ExecuteScalar());

                        // Insertar los detalles de la venta
                        foreach (var detalle in venta.Detalles)
                        {
                            SqlCommand cmdDetalle = new SqlCommand(
                                "INSERT INTO DetallePedido (VentaID, TipoMaterial, Cantidad, Precio, Subtotal) " +
                                "VALUES (@VentaID, @TipoMaterial, @Cantidad, @Precio, @Subtotal)", conn, transaction);

                            cmdDetalle.Parameters.AddWithValue("@VentaID", ventaId);
                            cmdDetalle.Parameters.AddWithValue("@TipoMaterial", detalle.TipoMaterial);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("@Precio", detalle.Precio);
                            cmdDetalle.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);

                            cmdDetalle.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ErrorLog.Log(ex.Message, "RegistrarVenta", "Central");
                        throw;
                    }
                }
            }
        }

        public static void ModificarVenta(Venta venta)
        {
            // Lógica para modificar la venta en la base de datos
            using (SqlConnection conn = new SqlConnection(constrg))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Actualizar la información de la venta en la tabla Venta
                        SqlCommand cmdVenta = new SqlCommand(
                            "UPDATE Venta SET Folio = @Folio, NombreCliente = @NombreCliente, NumeroContacto = @NumeroContacto, " +
                            "DetallesDomicilio = @DetallesDomicilio, FechaVenta = @FechaVenta, EstadoPago = @EstadoPago, Total = @Total " +
                            "WHERE ID = @ID", conn, transaction);

                        cmdVenta.Parameters.AddWithValue("@Folio", venta.Folio);
                        cmdVenta.Parameters.AddWithValue("@NombreCliente", venta.NombreCliente);
                        cmdVenta.Parameters.AddWithValue("@NumeroContacto", venta.NumeroContacto);
                        cmdVenta.Parameters.AddWithValue("@DetallesDomicilio", venta.DetallesDomicilio);
                        cmdVenta.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta);
                        cmdVenta.Parameters.AddWithValue("@EstadoPago", venta.EstadoPago);
                        cmdVenta.Parameters.AddWithValue("@Total", venta.Total);
                        cmdVenta.Parameters.AddWithValue("@ID", venta.ID);

                        cmdVenta.ExecuteNonQuery();

                        // Eliminar los detalles anteriores de la venta
                        SqlCommand cmdDeleteDetalles = new SqlCommand("DELETE FROM DetallePedido WHERE VentaID = @VentaID", conn, transaction);
                        cmdDeleteDetalles.Parameters.AddWithValue("@VentaID", venta.ID);
                        cmdDeleteDetalles.ExecuteNonQuery();

                        // Insertar los nuevos detalles
                        foreach (var detalle in venta.Detalles)
                        {
                            SqlCommand cmdDetalle = new SqlCommand(
                                "INSERT INTO DetallePedido (VentaID, TipoMaterial, Cantidad, Precio, Subtotal) " +
                                "VALUES (@VentaID, @TipoMaterial, @Cantidad, @Precio, @Subtotal)", conn, transaction);

                            cmdDetalle.Parameters.AddWithValue("@VentaID", venta.ID);
                            cmdDetalle.Parameters.AddWithValue("@TipoMaterial", detalle.TipoMaterial);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("@Precio", detalle.Precio);
                            cmdDetalle.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);

                            cmdDetalle.ExecuteNonQuery();
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ErrorLog.Log(ex.Message, "ModificarVenta", "Central");
                        throw;
                    }
                }
            }
        }

        public static void EliminarVenta(int ventaId)
        {
            // Lógica para eliminar la venta en la base de datos
            using (SqlConnection conn = new SqlConnection(constrg))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Primero eliminar los detalles de la venta
                        SqlCommand cmdDeleteDetalles = new SqlCommand("DELETE FROM DetallePedido WHERE VentaID = @VentaID", conn, transaction);
                        cmdDeleteDetalles.Parameters.AddWithValue("@VentaID", ventaId);
                        cmdDeleteDetalles.ExecuteNonQuery();

                        // Luego eliminar la venta
                        SqlCommand cmdDeleteVenta = new SqlCommand("DELETE FROM Venta WHERE ID = @ID", conn, transaction);
                        cmdDeleteVenta.Parameters.AddWithValue("@ID", ventaId);
                        cmdDeleteVenta.ExecuteNonQuery();

                        // Confirmar la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ErrorLog.Log(ex.Message, "EliminarVenta", "Central");
                        throw;
                    }
                }
            }
        }

        public static List<Venta> ObtenerVentas()
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection conn = new SqlConnection(constrg))
            {
                conn.Open();

                SqlCommand cmdVenta = new SqlCommand(
                    "SELECT V.ID AS VentaID, V.Folio, V.NombreCliente, V.NumeroContacto, V.DetallesDomicilio, V.FechaVenta, " +
                    "V.EstadoPago, V.Total, D.ID AS DetalleID, D.TipoMaterial, D.Cantidad, D.Precio, D.Subtotal " +
                    "FROM Venta V " +
                    "JOIN DetallePedido D ON V.ID = D.VentaID " +
                    "ORDER BY V.FechaVenta DESC", conn);

                SqlDataReader reader = cmdVenta.ExecuteReader();

                while (reader.Read())
                {
                    int ventaId = Convert.ToInt32(reader["VentaID"]);

                    // Buscar si la venta ya existe en la lista
                    Venta venta = ventas.FirstOrDefault(v => v.ID == ventaId);

                    if (venta == null)
                    {
                        venta = new Venta
                        {
                            ID = ventaId,
                            Folio = reader["Folio"].ToString(),
                            NombreCliente = reader["NombreCliente"].ToString(),
                            NumeroContacto = reader["NumeroContacto"].ToString(),
                            DetallesDomicilio = reader["DetallesDomicilio"].ToString(),
                            FechaVenta = Convert.ToDateTime(reader["FechaVenta"]),
                            EstadoPago = reader["EstadoPago"].ToString(),
                            Total = Convert.ToDecimal(reader["Total"]),
                            Detalles = new List<DetallePedido>()
                        };
                        ventas.Add(venta);
                    }

                    // Agregar el detalle de la venta
                    DetallePedido detalle = new DetallePedido
                    {
                        ID = Convert.ToInt32(reader["DetalleID"]),
                        TipoMaterial = reader["TipoMaterial"].ToString(),
                        Cantidad = Convert.ToDecimal(reader["Cantidad"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Subtotal = Convert.ToDecimal(reader["Subtotal"])
                    };

                    venta.Detalles.Add(detalle);
                }
            }

            return ventas;
        }

        public static string GenerarFolio()
        {
            string folio = string.Empty;
            string fechaActual = DateTime.Now.ToString("yyyyMMdd"); // Formato YYYYMMDD
            int numeroPedido = 1; // Por defecto, el primer pedido del día será el 1.

            using (SqlConnection conn = new SqlConnection(constrg))
            {
                conn.Open();

                // Consulta para obtener la cantidad de pedidos realizados en el día actual
                string query = "SELECT COUNT(*) FROM Venta WHERE CONVERT(varchar, FechaVenta, 112) = @FechaActual";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FechaActual", fechaActual);

                // Ejecutar la consulta y obtener el número de pedidos actuales
                numeroPedido = (int)cmd.ExecuteScalar() + 1; // Incrementamos en 1 para el siguiente pedido

                // Generar el folio con la estructura "PED-YYYYMMDD-000X"
                folio = $"PED-{fechaActual}-{numeroPedido.ToString("D4")}";
            }

            return folio;
        }

    }
}
