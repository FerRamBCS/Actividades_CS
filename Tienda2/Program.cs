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
            bool continuarPrograma = true;

            while (continuarPrograma)
            {
                Carrito carrito = new Carrito();
                bool continuar = true;

                Console.WriteLine("\n--------------------------------------");
                Console.WriteLine("¡Bienvenido! Nuevo cliente, ingrese sus productos.");
                Console.WriteLine("--------------------------------------");

                while (continuar)
                {
                    Console.WriteLine("\nLista de artículos disponibles:");
                    Catalogo.mostrarCatalogo();

                    int artId;
                    // Validar que el usuario ingrese un ID de artículo válido
                    while (true)
                    {
                        Console.Write("\nIngresa el ID del artículo que deseas: ");
                        if (int.TryParse(Console.ReadLine(), out artId) && artId > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingresa un número de ID válido.");
                        }
                    }

                    Articulo articuloSeleccionado = Catalogo.buscarArticuloId(artId);

                    if (articuloSeleccionado != null)
                    {
                        int cantidad;
                        // Validar que el usuario ingrese una cantidad válida
                        while (true)
                        {
                            Console.Write($"¿Cuántas unidades de '{articuloSeleccionado.Nombre}' deseas agregar? ");
                            if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida. Por favor, ingresa una cantidad mayor a 0.");
                            }
                        }

                        articuloSeleccionado.Cantidad = cantidad;
                        carrito.agregarArticulo(articuloSeleccionado);
                        Console.WriteLine($"El artículo '{articuloSeleccionado.Nombre}' ha sido agregado al carrito.");
                    }
                    else
                    {
                        Console.WriteLine("Artículo no encontrado.");
                    }

                    // Preguntar si el usuario desea continuar agregando artículos
                    char respuesta;
                    while (true)
                    {
                        Console.WriteLine("\n¿Deseas agregar otro artículo? (s/n)");
                        respuesta = Console.ReadKey(true).KeyChar;
                        respuesta = char.ToLower(respuesta);

                        if (respuesta == 's' || respuesta == 'n')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, presiona 's' para sí o 'n' para no.");
                        }
                    }

                    continuar = respuesta == 's';
                }

                carrito.mostrarCarrito();

                // Ir a caja
                Caja caja = new Caja(1);

                // Mostrar total
                caja.ingresarCarrito(carrito);

                // Cobrar caja
                caja.cobrarCaja();

                // Preguntar si se va a atender a otro cliente
                Console.WriteLine("\n¿Desea atender a otro cliente? (s/n)");
                char respuestaPrograma = Console.ReadKey(true).KeyChar;
                respuestaPrograma = char.ToLower(respuestaPrograma);

                if (respuestaPrograma != 's')
                {
                    continuarPrograma = false;
                    Console.WriteLine("\nPrograma finalizado. ¡Gracias por usar el sistema de la tienda!");
                    Console.ReadKey();
                }
            }
        }
    }
}