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
            Console.WriteLine("Selecciona el articulo: ");
            Catalogo.mostrarCatalogo();

            int artId = Convert.ToInt32(Console.ReadLine());

            Articulo articuloSeleccionado = Catalogo.buscarArticuloId(artId);
            /*
             TAREA
            Agregar el articulo al carrito
             */

            Console.ReadLine();
        }
    }
}
