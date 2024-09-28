using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2
{
    class Caja
    {
        private static int numCompraGlobal = 0;
        public int Numero { get; set; }
        private decimal Pagando { get; set; }
        private float Cambio { get; set; }
        private Carrito Cart { get; set; }
        private float subTotal = 0;
        private float Total = 0;
        public int numCompra { get; private set; }

        public Caja(int numero)
        {
            Numero = numero;
            numCompraGlobal++;
            numCompra = numCompraGlobal;
        }

        public void ingresarCarrito(Carrito carrito)
        {
            Cart = carrito;
            subTotal = 0;

            foreach (Articulo articulo in carrito.Lista)
            {
                subTotal += articulo.Precio * articulo.Cantidad;
            }

            mostrarTotal();
        }

        public void mostrarTotal()
        {
            float IVA = subTotal * 0.16f;
            Total = subTotal + IVA;

            // Mostrar correctamente el subtotal, IVA y total con formato alineado
            Console.WriteLine("\nResumen de la Compra");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Subtotal: {subTotal,15:C2}");
            Console.WriteLine($"IVA 16%:  {IVA,15:C2}");
            Console.WriteLine($"Total:    {Total,15:C2}");
            Console.WriteLine("-------------------------------");
        }

        public void cobrarCaja()
        {
            Console.WriteLine("Ingresa el monto para pagar:");
            Pagando = Convert.ToDecimal(Console.ReadLine());

            // Validar si el monto pagado es suficiente
            while (Pagando < (decimal)Total)
            {
                Console.WriteLine($"El monto ingresado es insuficiente. Debe ser igual o mayor a {Total:C2}");
                Pagando = Convert.ToDecimal(Console.ReadLine());
            }

            Cambio = (float)Pagando - Total;
            Console.WriteLine($"Pago recibido. Su cambio es: {Cambio:C2}");

            // Generar el ticket
            Ticket ticket = new Ticket(Cart.Lista, Total, Pagando, Cambio, numCompra, DateTime.Now);
            ticket.Imprimir();
        }
    }
}