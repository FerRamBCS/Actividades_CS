using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBE_SV.Entidades
{
    class LoggerCamPrecios
    {
        public int ID { get; set; }                // ID único del log
        public string Material { get; set; }       // Material cuyo precio cambió
        public decimal PrecioAnterior { get; set; }// Precio anterior
        public decimal PrecioNuevo { get; set; }   // Nuevo precio
        public DateTime Fecha { get; set; }        // Fecha del cambio de precio
        public string UsuarioResponsable { get; set; } // Usuario que realizó el cambio
    }
}
