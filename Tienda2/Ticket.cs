using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2
{
    class Ticket
    {
        public List<Articulo> Lista { get; set; }
        public decimal Total { get; set; }
        public decimal Pagado { get; set; }
        public decimal Cambio { get; set; }
        public DateTime Fecha { get; set; }
        public int numCompra { get; set; }
        public decimal IVA { get; set; }

        public Ticket(List<Articulo> lista, float total, decimal pagado, float cambio, int numCompra, DateTime fecha)
        {
            Lista = lista;
            Total = (decimal)total;
            Pagado = pagado;
            Cambio = (decimal)cambio;
            this.numCompra = numCompra;
            Fecha = fecha;
            IVA = Total * 0.16m;
        }

        public void Imprimir()
        {
            Console.Clear();
            Console.WriteLine("*********** TICKET DE COMPRA ***********");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Caja: {1}");
            Console.WriteLine($"Número de Compra: {numCompra}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"{"Artículo",-20} {"Cant.",-5} {"P.U.",-10} {"Total",-10}");
            Console.WriteLine("---------------------------------------");

            foreach (Articulo articulo in Lista)
            {
                Console.WriteLine($"{articulo.Nombre,-20} {articulo.Cantidad,-5} {articulo.Precio,-10:C2} {(articulo.Precio * articulo.Cantidad),-10:C2}");
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Subtotal: {Total - IVA,32:C2}");
            Console.WriteLine($"IVA 16%:  {IVA,32:C2}");
            Console.WriteLine($"Total:    {Total,32:C2}");
            Console.WriteLine($"Pagado:   {Pagado,32:C2}");
            Console.WriteLine($"Cambio:   {Cambio,32:C2}");
            Console.WriteLine("****************************************");
        }
    }
}