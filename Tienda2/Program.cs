using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecciona el artículo: ");
                Catalogo.mostrarCatalogo();

                int artId = Convert.ToInt32(Console.ReadLine());

                Articulo articuloSeleccionado = Catalogo.buscarArticuloId(artId);

                if (articuloSeleccionado != null)
                {
                    Console.WriteLine($"¿Cuántas unidades de '{articuloSeleccionado.Nombre}' deseas agregar?");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    articuloSeleccionado.Cantidad = cantidad; // Asigna la cantidad seleccionada

                    carrito.agregarArticulo(articuloSeleccionado);
                    Console.WriteLine($"El artículo '{articuloSeleccionado.Nombre}' ha sido agregado al carrito.");
                }
                else
                {
                    Console.WriteLine("Artículo no encontrado.");
                }

                Console.WriteLine("¿Deseas agregar otro artículo? (s/n)");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    continuar = false;
                }
            }

            // Mostrar los artículos agregados al carrito
            carrito.mostrarCarrito();

            // Ir a caja
            Caja caja = new Caja(1);

            // Mostrar total
            caja.ingresarCarrito(carrito);
            
            Console.ReadLine();
        }
    }
}
