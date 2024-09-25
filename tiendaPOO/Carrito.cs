using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaPOO
{
    class Carrito
    {
        public List<Producto> Lista { get; set; } = new List<Producto>();

        // Método para agregar un producto al carrito con validación
        public void agregarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                Console.WriteLine("El nombre del producto no puede estar vacío o contener solo espacios en blanco.");
                return;
            }

            if (producto.Cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
                return;
            }

            if (producto.Precio <= 0)
            {
                Console.WriteLine("El precio debe ser mayor que cero.");
                return;
            }

            // Verificar si el producto ya existe en el carrito
            var productoExistente = Lista.FirstOrDefault(p => p.Nombre.Equals(producto.Nombre, StringComparison.OrdinalIgnoreCase));
            if (productoExistente != null)
            {
                productoExistente.Cantidad += producto.Cantidad;
                Console.WriteLine($"La cantidad del producto '{producto.Nombre}' ha sido actualizada a {productoExistente.Cantidad}.");
            }
            else
            {
                Lista.Add(producto);
                Console.WriteLine($"Producto '{producto.Nombre}' agregado al carrito.");
            }
        }

        // Método para mostrar el carrito con formato
        public void mostrarCarrito()
        {
            if (Lista.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }

            decimal totalGeneral = 0;

            Console.WriteLine("=====================================");
            Console.WriteLine("| Nombre     | Cantidad | Precio | Total |");
            Console.WriteLine("=====================================");

            foreach (var producto in Lista)
            {
                decimal totalProducto = producto.Cantidad * producto.Precio;
                totalGeneral += totalProducto;

                Console.WriteLine($"| {producto.Nombre,-10} | {producto.Cantidad,8} | {producto.Precio,6:C} | {totalProducto,6:C} |");
            }

            Console.WriteLine("=====================================");
            Console.WriteLine($"Total general del carrito: {totalGeneral:C}");
        }

        // Método para eliminar un producto del carrito
        public void eliminarProducto()
        {
            if (Lista.Count == 0)
            {
                Console.WriteLine("El carrito está vacío. No hay productos para eliminar.");
                return;
            }

            Console.WriteLine("Ingrese el nombre del producto que desea eliminar:");
            string nombreProducto = Console.ReadLine();

            var producto = Lista.FirstOrDefault(p => p.Nombre.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase));
            if (producto != null)
            {
                Lista.Remove(producto);
                Console.WriteLine($"Producto '{nombreProducto}' eliminado del carrito.");
            }
            else
            {
                Console.WriteLine($"El producto '{nombreProducto}' no se encuentra en el carrito.");
            }
        }
    }
}
