using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBE_SV.Entidades
{
    class DetallePedido
    {
        public int ID { get; set; }                 // ID único del detalle
        public string TipoMaterial { get; set; }    // Tipo de material (arena, grava, etc.)
        public decimal Cantidad { get; set; }       // Cantidad en metros cúbicos
        public decimal Precio { get; set; }         // Precio unitario del material
        public decimal Subtotal { get; set; }       // Subtotal del material
    }
}
