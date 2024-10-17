using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBE_SV.Entidades
{
    class Inventario
    {
        public int ID { get; set; }                 // ID único del registro de inventario
        public string Material { get; set; }        // Tipo de material (arena, grava, etc.)
        public int CantidadDisponible { get; set; } // Cantidad disponible en metros cúbicos
        public DateTime FechaIngreso { get; set; }  // Fecha de ingreso del material al inventario
    }
}
