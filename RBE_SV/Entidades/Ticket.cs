using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBE_SV.Entidades
{
    class Ticket
    {
        public int ID { get; set; }               // ID único del ticket
        public string FolioVenta { get; set; }    // Folio de la venta
        public DateTime Fecha { get; set; }       // Fecha del ticket
        public string DetallesCliente { get; set; }// Detalles del cliente
        public List<DetallePedido> Detalles { get; set; } // Detalles del pedido
        public decimal Total { get; set; }        // Total de la venta
    }
}
