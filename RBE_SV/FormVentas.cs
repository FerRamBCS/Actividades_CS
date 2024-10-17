using RBE_SV.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBE_SV
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // Carga las ventas
            CargarVentas();

            // Deshabilitar los TextBox de cantidad, precio unitario y subtotal para todos los materiales
            Txt_Pu1.Enabled = false;
            Txt_St1.Enabled = false;

            Txt_Pu2.Enabled = false;
            Txt_St2.Enabled = false;

            Txt_Pu3.Enabled = false;
            Txt_St3.Enabled = false;

            Txt_Pu4.Enabled = false;
            Txt_St4.Enabled = false;
            Txt_FolioVenta.ReadOnly = true;

            // Generar el folio automáticamente cuando el formulario se carga o cuando se crea un nuevo pedido
            Txt_FolioVenta.Text = Central.GenerarFolio();

        }

        private bool ValidarFolio()
        {
            // Expresión regular para validar la nomenclatura "PED-YYYYMMDD-XXXX"
            string pattern = @"^PED-\d{8}-\d{4}$";

            if (!Regex.IsMatch(Txt_FolioVenta.Text, pattern))
            {
                MessageBox.Show("El folio no sigue la nomenclatura correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void Btn_RegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar los campos necesarios
                if (ValidarCampos())
                {
                    // Generar el folio solo si estamos listos para registrar la venta
                    Txt_FolioVenta.Text = Central.GenerarFolio();

                    // Crear el objeto Venta con los valores del formulario
                    Venta venta = new Venta
                    {
                        Folio = Txt_FolioVenta.Text,  // Ahora tiene un valor válido
                        NombreCliente = Txt_NombreCliente.Text,
                        NumeroContacto = Txt_TelCLiente.Text,
                        DetallesDomicilio = $"{Txt_Manzana.Text} {Txt_Lote.Text}, {Txt_Colonia.Text}",
                        FechaVenta = DateTime.Now,
                        EstadoPago = Cb_EstadoPago.SelectedItem.ToString(),
                        Total = Convert.ToDecimal(Txt_TotalVenta.Text),
                        Detalles = new List<DetallePedido>()
                    };

                    // Agregar los detalles de los materiales
                    if (Cb_Mat1.SelectedItem != null)
                    {
                        venta.Detalles.Add(new DetallePedido
                        {
                            TipoMaterial = Cb_Mat1.SelectedItem.ToString(),
                            Cantidad = Convert.ToDecimal(Txt_CanMat1.Text),
                            Precio = Convert.ToDecimal(Txt_Pu1.Text),
                            Subtotal = Convert.ToDecimal(Txt_St1.Text)
                        });
                    }

                    // Repetir para otros materiales si es necesario

                    // Llamar a la función para registrar la venta
                    Central.RegistrarVenta(venta);

                    MessageBox.Show("Venta registrada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar la venta: {ex.Message}");
            }
        }
        private void RegistrarMaterial(Venta venta, ComboBox cbMaterial, TextBox txtCantidad, TextBox txtPrecio, TextBox txtSubtotal)
        {
            if (!string.IsNullOrEmpty(cbMaterial.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtPrecio.Text))
            {
                // Crear un nuevo DetallePedido con la información del material
                DetallePedido detalle = new DetallePedido
                {
                    TipoMaterial = cbMaterial.Text,
                    Cantidad = Convert.ToDecimal(txtCantidad.Text),
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Subtotal = Convert.ToDecimal(txtSubtotal.Text)
                };

                // Agregar el detalle a la lista de detalles de la venta
                venta.Detalles.Add(detalle);
            }
        }

        private bool ValidarCampos()
        {
            // Valida que los campos esenciales estén completos
            if (string.IsNullOrEmpty(Txt_NombreCliente.Text) ||
                string.IsNullOrEmpty(Txt_TelCLiente.Text) ||
                string.IsNullOrEmpty(Cb_EstadoPago.Text))
            {
                return false; // Los campos no están completos
            }

            // Al menos uno de los materiales debe tener datos
            if (string.IsNullOrEmpty(Cb_Mat1.Text) && string.IsNullOrEmpty(Cb_Mat2.Text))
            {
                return false; // No hay material seleccionado
            }

            return true;
        }


        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Ventas.SelectedRows.Count > 0)
                {
                    // Validar que el ComboBox Material 1 tiene un valor seleccionado
                    if (Cb_Mat1.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, selecciona un material en el ComboBox 1.");
                        return; // Salir del método si no se seleccionó un material
                    }

                    // Repetir la validación para otros ComboBox de materiales (Material 2, Material 3, etc.)
                    if (Cb_Mat2.SelectedItem == null && !string.IsNullOrEmpty(Txt_CanMat2.Text))
                    {
                        MessageBox.Show("Por favor, selecciona un material en el ComboBox 2.");
                        return;
                    }

                    // Si todos los ComboBox son válidos, proceder con la modificación de la venta

                    int ventaId = Convert.ToInt32(DGV_Ventas.SelectedRows[0].Cells["VentaID"].Value);

                    // Crear el objeto Venta con los valores del formulario
                    Venta venta = new Venta
                    {
                        ID = ventaId,
                        Folio = Txt_FolioVenta.Text,
                        NombreCliente = Txt_NombreCliente.Text,
                        NumeroContacto = Txt_TelCLiente.Text,
                        DetallesDomicilio = $"{Txt_Manzana.Text} {Txt_Lote.Text}, {Txt_Colonia.Text}",
                        FechaVenta = DateTime.Now,
                        EstadoPago = Cb_EstadoPago.SelectedItem?.ToString() ?? "",
                        Total = Convert.ToDecimal(Txt_TotalVenta.Text),
                        Detalles = new List<DetallePedido>()
                    };

                    // Agregar detalles de los materiales seleccionados
                    venta.Detalles.Add(new DetallePedido
                    {
                        TipoMaterial = Cb_Mat1.SelectedItem.ToString(),
                        Cantidad = Convert.ToDecimal(Txt_CanMat1.Text),
                        Precio = Convert.ToDecimal(Txt_Pu1.Text),
                        Subtotal = Convert.ToDecimal(Txt_St1.Text)
                    });

                    // Verificar y agregar otros materiales si están seleccionados
                    if (Cb_Mat2.SelectedItem != null)
                    {
                        venta.Detalles.Add(new DetallePedido
                        {
                            TipoMaterial = Cb_Mat2.SelectedItem.ToString(),
                            Cantidad = Convert.ToDecimal(Txt_CanMat2.Text),
                            Precio = Convert.ToDecimal(Txt_Pu2.Text),
                            Subtotal = Convert.ToDecimal(Txt_St2.Text)
                        });
                    }

                    // Llamar al método para modificar la venta en la base de datos
                    Central.ModificarVenta(venta);

                    MessageBox.Show("Venta modificada exitosamente.");
                    CargarVentas();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una venta para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se ha seleccionado una venta en el DataGridView
                if (DGV_Ventas.SelectedRows.Count > 0)
                {
                    // Confirmar si el usuario realmente desea eliminar la venta
                    if (MessageBox.Show("¿Está seguro de que desea eliminar esta venta?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Obtener el ID de la venta seleccionada
                        int ventaId = Convert.ToInt32(DGV_Ventas.SelectedRows[0].Cells["VentaID"].Value);

                        // Eliminar la venta (esto también debe eliminar los detalles relacionados si los hay)
                        Central.EliminarVenta(ventaId);

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Venta eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar las ventas para actualizar el DataGridView
                        CargarVentas();

                        // Limpiar el formulario después de eliminar la venta
                        LimpiarFormulario();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una venta para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos del formulario
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            Txt_FolioVenta.Clear();
            Txt_NombreCliente.Clear();
            Txt_TelCLiente.Clear();
            Txt_Colonia.Clear();
            Txt_Manzana.Clear();
            Txt_Lote.Clear();
            Txt_Descripcion.Clear();
            Cb_Mat1.SelectedIndex = -1;
            Txt_CanMat1.Clear();
            Txt_Pu1.Clear();
            Txt_St1.Clear();
            Cb_Mat2.SelectedIndex = -1;
            Txt_CanMat2.Clear();
            Txt_Pu2.Clear();
            Txt_St2.Clear();
            Cb_Mat3.SelectedIndex = -1;
            Txt_CanMat3.Clear();
            Txt_Pu3.Clear();
            Txt_St3.Clear();
            Cb_Mat4.SelectedIndex = -1;
            Txt_CanMat4.Clear();
            Txt_Pu4.Clear();
            Txt_St4.Clear();
            Cb_EstadoPago.SelectedIndex = -1;
            Txt_TotalVenta.Clear();
        }
        private void CargarVentas()
        {
            try
            {
                // Obtener las ventas de la base de datos a través de la clase Central
                List<Venta> ventas = Central.ObtenerVentas();

                // Crear una lista temporal para mostrar los datos en el DataGridView
                var listaVentas = ventas.Select(v => new
                {
                    VentaID = v.ID,
                    Folio = v.Folio,
                    NombreCliente = v.NombreCliente,
                    NumeroContacto = v.NumeroContacto,
                    DetallesDomicilio = v.DetallesDomicilio,
                    FechaVenta = v.FechaVenta,
                    EstadoPago = v.EstadoPago,
                    Total = v.Total
                }).ToList();

                // Asignar la lista al DataGridView
                DGV_Ventas.DataSource = listaVentas;

                // Ajustar columnas si es necesario
                DGV_Ventas.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_Ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que se ha seleccionado una fila válida
            {
                // Obtener el ID de la venta seleccionada
                int ventaID = Convert.ToInt32(DGV_Ventas.Rows[e.RowIndex].Cells["VentaID"].Value);

                // Obtener la venta seleccionada de la lista de ventas
                Venta ventaSeleccionada = Central.ObtenerVentas().FirstOrDefault(v => v.ID == ventaID);

                if (ventaSeleccionada != null)
                {
                    // Crear una lista temporal para mostrar los detalles en el DataGridView
                    var listaDetalles = ventaSeleccionada.Detalles.Select(d => new
                    {
                        TipoMaterial = d.TipoMaterial,
                        Cantidad = d.Cantidad,
                        Precio = d.Precio,
                        Subtotal = d.Subtotal
                    }).ToList();

                    // Asignar la lista de detalles al segundo DataGridView
                    DGV_Detalles.DataSource = listaDetalles;

                    // Ajustar columnas si es necesario
                    DGV_Detalles.AutoResizeColumns();
                }
            }
        }

        private void DGV_Detalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalcularSubtotal(TextBox txtCantidad, TextBox txtPrecioUnitario, TextBox txtSubtotal)
        {
            // Verificar si los valores ingresados son válidos
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad) &&
                decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario))
            {
                // Calcular el subtotal
                decimal subtotal = cantidad * precioUnitario;
                txtSubtotal.Text = subtotal.ToString("F2"); // Mostrar con dos decimales
            }
            else
            {
                // Si los valores no son válidos, limpiar el campo de subtotal
                txtSubtotal.Clear();
            }

            // Después de calcular el subtotal, actualizar el total de la venta
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            // Inicializar el total
            decimal total = 0;

            // Sumar todos los subtotales de los materiales
            if (decimal.TryParse(Txt_St1.Text, out decimal subtotal1))
                total += subtotal1;

            if (decimal.TryParse(Txt_St2.Text, out decimal subtotal2))
                total += subtotal2;

            if (decimal.TryParse(Txt_St3.Text, out decimal subtotal3))
                total += subtotal3;

            if (decimal.TryParse(Txt_St4.Text, out decimal subtotal4))
                total += subtotal4;

            // Mostrar el total en el campo correspondiente
            Txt_TotalVenta.Text = total.ToString("F2"); // Mostrar con dos decimales
        }

        private void Cb_Mat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si el elemento seleccionado no es nulo
            if (Cb_Mat1.SelectedItem != null)
            {
                // Ajustar el precio unitario según el material seleccionado
                switch (Cb_Mat1.SelectedItem.ToString())
                {
                    case "Arena Normal":
                        Txt_CanMat1.Text = "1";
                        Txt_Pu1.Text = "370"; // Precio para Arena Normal
                        break;
                    case "Arena Cernida":
                        Txt_CanMat1.Text = "1";
                        Txt_Pu1.Text = "590"; // Precio para Arena Cernida
                        break;
                    case "Arena Fina":
                        Txt_CanMat1.Text = "1";
                        Txt_Pu1.Text = "690"; // Precio para Arena Fina
                        break;
                    case "Grava":
                        Txt_CanMat1.Text = "1";
                        Txt_Pu1.Text = "870"; // Precio para Grava
                        break;
                }

                // Recalcular el subtotal después de cambiar el material
                CalcularSubtotal(Txt_CanMat1, Txt_Pu1, Txt_St1);
            }
            else
            {
                // Si no hay un material seleccionado, limpiar los campos
                Txt_Pu1.Clear();
                Txt_CanMat1.Clear();
                Txt_St1.Clear();
            }
        }

        private void Cb_Mat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Mat2.SelectedItem != null)
            {
                switch (Cb_Mat2.SelectedItem.ToString())
                {
                    case "Arena Normal":
                        Txt_CanMat2.Text = "1";
                        Txt_Pu2.Text = "370";
                        break;
                    case "Arena Cernida":
                        Txt_CanMat2.Text = "1";
                        Txt_Pu2.Text = "590";
                        break;
                    case "Arena Fina":
                        Txt_CanMat2.Text = "1";
                        Txt_Pu2.Text = "690";
                        break;
                    case "Grava":
                        Txt_CanMat2.Text = "1";
                        Txt_Pu2.Text = "870";
                        break;
                }

                CalcularSubtotal(Txt_CanMat2, Txt_Pu2, Txt_St2);
            }
            else
            {
                // Si no hay un material seleccionado, limpiar los campos
                Txt_Pu2.Clear();
                Txt_CanMat2.Clear();
                Txt_St2.Clear();
            }
        }

        private void Cb_Mat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Mat3.SelectedItem != null)
            {
                switch (Cb_Mat3.SelectedItem.ToString())
                {
                    case "Arena Normal":
                        Txt_CanMat3.Text = "1";
                        Txt_Pu3.Text = "370";
                        break;
                    case "Arena Cernida":
                        Txt_CanMat3.Text = "1";
                        Txt_Pu3.Text = "590";
                        break;
                    case "Arena Fina":
                        Txt_CanMat3.Text = "1";
                        Txt_Pu3.Text = "690";
                        break;
                    case "Grava":
                        Txt_CanMat3.Text = "1";
                        Txt_Pu3.Text = "870";
                        break;
                }

                CalcularSubtotal(Txt_CanMat3, Txt_Pu3, Txt_St3);
            }
            else
            {
                // Si no hay un material seleccionado, limpiar los campos
                Txt_Pu3.Clear();
                Txt_CanMat3.Clear();
                Txt_St3.Clear();
            }
        }

        private void Cb_Mat4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Mat4.SelectedItem != null)
            {
                switch (Cb_Mat4.SelectedItem.ToString())
                {
                    case "Arena Normal":
                        Txt_CanMat4.Text = "1";
                        Txt_Pu4.Text = "370";
                        break;
                    case "Arena Cernida":
                        Txt_CanMat4.Text = "1";
                        Txt_Pu4.Text = "590";
                        break;
                    case "Arena Fina":
                        Txt_CanMat4.Text = "1";
                        Txt_Pu4.Text = "690";
                        break;
                    case "Grava":
                        Txt_CanMat4.Text = "1";
                        Txt_Pu4.Text = "870";
                        break;
                }

                CalcularSubtotal(Txt_CanMat4, Txt_Pu4, Txt_St4);
            }
            else
            {
                // Si no hay un material seleccionado, limpiar los campos
                Txt_Pu4.Clear();
                Txt_CanMat4.Clear();
                Txt_St4.Clear();
            }
        }

        private void Txt_CanMat1_TextChanged(object sender, EventArgs e)
        {
            // Calcular el subtotal del material 1 cuando cambia la cantidad
            CalcularSubtotal(Txt_CanMat1, Txt_Pu1, Txt_St1);
        }

        private void Txt_CanMat2_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal(Txt_CanMat2, Txt_Pu2, Txt_St2);    
        }

        private void Txt_CanMat3_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal(Txt_CanMat3, Txt_Pu3 , Txt_St3);
        }

        private void Txt_CanMat4_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal(Txt_CanMat4, Txt_Pu4 , Txt_St4);
        }

        private void Txt_Pu1_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal(Txt_CanMat1, Txt_Pu1, Txt_St1); // Recalcular el subtotal si se cambia el precio unitario
        }

        private void Txt_Pu2_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal(Txt_CanMat2, Txt_Pu2 , Txt_St2);
        }

        private void Txt_Pu3_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal(Txt_CanMat3, Txt_Pu3, Txt_St3);
        }

        private void Txt_Pu4_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal(Txt_CanMat4, Txt_Pu4, Txt_St4);
        }

        private void Txt_CanMat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y una coma (para decimales), y evitar otros caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_CanMat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y una coma (para decimales), y evitar otros caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_CanMat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y una coma (para decimales), y evitar otros caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_CanMat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y una coma (para decimales), y evitar otros caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_Pu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar solo números y un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_Pu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar solo números y un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_Pu3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar solo números y un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_Pu4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar solo números y un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_NombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

    }
    
}
