using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBE_SV.Entidades
{
    class Producto
    {
        public int ID { get; set; }               // ID único del producto
        public string Nombre { get; set; }        // Nombre del producto
        public decimal Precio { get; set; }       // Precio del producto
        public int CantidadDisponible { get; set; }// Cantidad disponible en inventario
    }
}
