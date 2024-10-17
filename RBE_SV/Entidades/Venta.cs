using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBE_SV.Entidades
{
    class Venta
    {
        public int ID { get; set; }                    // ID único de la venta
        public string Folio { get; set; }              // Folio de la venta (DMA_NumVenta)
        public DateTime FechaVenta { get; set; }       // Fecha de la venta
        public string NombreCliente { get; set; }      // Nombre del cliente
        public string NumeroContacto { get; set; }     // Número de contacto del cliente
        public string DetallesDomicilio { get; set; }  // Dirección del cliente
        public List<DetallePedido> Detalles { get; set; } // Detalles del pedido (productos comprados)
        public string EstadoPago { get; set; }         // Estado de pago (Pagado, Por Cobrar)
        public decimal Total {  get; set; }
    }
}
