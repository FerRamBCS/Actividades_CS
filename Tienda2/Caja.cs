using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2
{
    class Caja
    {
        private static int numCompra = 0;
        public int Numero { get; set; }
        private decimal Pagando { get; set; }
        private float Cambio { get; set; }
        private Carrito Cart { get; set; }
        private float subTotal = 0;
        private float Total = 0;

        public Caja(int numero)
        {
            Numero = numero;
        }

        public void ingresarCarrito(Carrito carrito)
        {
            Cart = carrito;
            subTotal = 0; // Reiniciar el subtotal para evitar acumulaciones previas

            foreach (Articulo articulo in carrito.Lista)
            {
                subTotal += articulo.Precio * articulo.Cantidad; // Calcular correctamente el subtotal
            }

            mostrarTotal(); // Llamar a mostrarTotal después de calcular el subtotal
        }

        public void mostrarTotal()
        {
            float IVA = subTotal * 0.16f;
            Total = subTotal + IVA;

            // Mostrar correctamente el subtotal, IVA y total
            Console.WriteLine($"El subtotal es: {subTotal}");
            Console.WriteLine($"El IVA 16% es: {IVA}");
            Console.WriteLine($"El total es: {Total}");
            cobrarCaja();
        }

        public void cobrarCaja()
        {
            Console.WriteLine("Ingresa el monto para pagar:");
            Pagando = Convert.ToDecimal(Console.ReadLine());

            // Validar si el monto pagado es suficiente
            while (Pagando < (decimal)Total)
            {
                Console.WriteLine($"El monto ingresado es insuficiente. Debe ser igual o mayor a {Total}");
                Pagando = Convert.ToDecimal(Console.ReadLine());
            }

            Cambio = (float)Pagando - Total;
            Console.WriteLine($"Pago recibido. Su cambio es: {Cambio}");

            // Ahora imprimimos el ticket una vez realizado el pago
            imprimirTicket();
        }

        private void imprimirTicket()
        {
            Console.Clear();
            numCompra++;
            DateTime Fecha = DateTime.UtcNow;
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Caja: {Numero}");
            Console.WriteLine($"Num. de Compra: {numCompra}");
            Console.WriteLine("---------------------------------------");

            foreach (Articulo articulo in Cart.Lista)
            {
                Console.WriteLine($"{articulo.Nombre} - ${articulo.Precio} x {articulo.Cantidad} = ${articulo.Precio * articulo.Cantidad}");
            }

            Console.WriteLine("---------------------------------------");

            Console.WriteLine($"Subtotal: {subTotal}");
            Console.WriteLine($"IVA 16%: {subTotal * 0.16f}");
            Console.WriteLine($"Total: {Total}");
            Console.WriteLine($"Pagado: {Pagando}");
            Console.WriteLine($"Cambio: {Cambio}");
        }
    }
}