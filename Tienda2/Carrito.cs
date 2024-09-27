using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2
{
    class Carrito
    {
        public List<Articulo> Lista { get; set; }

        public Carrito() 
        { 
            Lista = new List<Articulo>();
        }

        public void agregarArticulo(Articulo articulo)
        {
            Lista.Add(articulo);
        }
        public void mostrarCarrito() 
        {
            Console.WriteLine("Articulos en el carrito");
            foreach (var articulo in Lista) 
            {
                Console.WriteLine($"{articulo.ID} - {articulo.Nombre} - {articulo.Precio}");
            }
        }
    }
}
