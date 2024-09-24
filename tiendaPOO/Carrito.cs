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

        public void agregarProducto(Producto producto)
        {

            Lista.Add(producto);

        }

        public void mostrarCarrito()
        {
            for (int i = 0; i < Lista.Count; i++) 
            { 
                Console.WriteLine($"Nombre: {Lista[i].Nombre}, " + $"Cantidad: {Lista[i].Cantidad}, "
                    + $"Precio: {Lista[i].Precio}, " + $"Total: {Lista[i].Cantidad * Lista[i].Precio}");
            }
        }
    }
}
