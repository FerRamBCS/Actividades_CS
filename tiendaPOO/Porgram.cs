using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();
            string continuar = "S";

            while (continuar.ToUpper() == "S")
            {
                // Solicitar información del producto
                Console.WriteLine("Ingrese el nombre del producto:");
                string nombre = Console.ReadLine().Trim();

                Console.WriteLine("Ingrese la cantidad:");
                int cantidad;
                while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
                {
                    Console.WriteLine("Por favor, ingrese una cantidad válida mayor a 0:");
                }

                Console.WriteLine("Ingrese el precio:");
                decimal precio;
                while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un precio válido mayor a 0:");
                }

                Producto producto = new Producto
                {
                    Nombre = nombre,
                    Cantidad = cantidad,
                    Precio = precio
                };

                carrito.agregarProducto(producto);

                // Preguntar si desea continuar ingresando productos
                Console.WriteLine("¿Desea agregar otro producto? (S/N)");
                continuar = Console.ReadLine().Trim().ToUpper();
            }

            // Proceder al cobro utilizando la clase Caja
            Caja caja = new Caja();
            caja.Cobrar(carrito);

            Console.ReadLine(); // Esperar la entrada del usuario antes de cerrar
        }
    }
}
