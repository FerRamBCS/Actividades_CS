using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tiendaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carrito carrito = new Carrito();

            string nombre = "";
            int cantidad = 0;
            decimal precio = 0;

            Console.WriteLine("Ingrese nombre de producto ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio ");
            precio = Convert.ToDecimal(Console.ReadLine());

            Producto producto = new Producto();
            producto.Nombre = nombre;
            producto.Cantidad = cantidad;
            producto.Precio = precio;
            carrito.agregarProducto(producto);

            Caja caja = new Caja();
            caja.Cobrar(carrito);

            carrito.mostrarCarrito();
            Console.ReadLine();
        }
    }
}
