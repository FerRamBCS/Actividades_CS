using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaPOO
{
    class Caja
    {
        // Mostrar la lista de productos y el total
        public void Cobrar(Carrito carrito)
        {
            // Verificar si el carrito tiene productos
            if (carrito.Lista.Count == 0)
            {
                Console.WriteLine("El carrito está vacío. No hay nada que cobrar.");
                return;
            }

            // Mostrar los productos en el carrito
            Console.WriteLine("=====================================");
            Console.WriteLine("| Nombre     | Cantidad | Precio | Total |");
            Console.WriteLine("=====================================");

            decimal totalGeneral = 0;

            foreach (var producto in carrito.Lista)
            {
                decimal totalProducto = producto.Cantidad * producto.Precio;
                totalGeneral += totalProducto;

                Console.WriteLine($"| {producto.Nombre,-10} | {producto.Cantidad,8} | {producto.Precio,6:C} | {totalProducto,6:C} |");
            }

            Console.WriteLine("=====================================");
            Console.WriteLine($"Total general del carrito: {totalGeneral:C}");

            // Preguntar al usuario si desea eliminar algún producto
            Console.WriteLine("¿Desea eliminar algún producto del carrito? (S/N)");
            string respuesta = Console.ReadLine().Trim().ToUpper();

            while (respuesta == "S")
            {
                carrito.eliminarProducto(); // Llama al método para eliminar productos

                // Mostrar el carrito actualizado
                Console.WriteLine("=====================================");
                Console.WriteLine("| Nombre     | Cantidad | Precio | Total |");
                Console.WriteLine("=====================================");

                totalGeneral = 0; // Reiniciar el total general

                foreach (var producto in carrito.Lista)
                {
                    decimal totalProducto = producto.Cantidad * producto.Precio;
                    totalGeneral += totalProducto;

                    Console.WriteLine($"| {producto.Nombre,-10} | {producto.Cantidad,8} | {producto.Precio,6:C} | {totalProducto,6:C} |");
                }

                Console.WriteLine("=====================================");
                Console.WriteLine($"Total general del carrito: {totalGeneral:C}");

                // Preguntar nuevamente si desea eliminar otro producto
                Console.WriteLine("¿Desea eliminar otro producto? (S/N)");
                respuesta = Console.ReadLine().Trim().ToUpper();
            }

            // Proceso de pago
            Console.WriteLine("Ingrese el monto con el que va a pagar:");
            decimal montoPago = Convert.ToDecimal(Console.ReadLine());

            if (montoPago >= totalGeneral)
            {
                decimal cambio = montoPago - totalGeneral;
                Console.WriteLine($"Pago exitoso. Su cambio es: {cambio:C}");
            }
            else
            {
                Console.WriteLine("Monto insuficiente. Por favor, ingrese un monto válido.");
            }
        }
    }
}
