using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2
{
    class Catalogo
    {
        public List<Articulo> Inventario{ get; set; }

        public Catalogo() 
        {
            Inventario = new List<Articulo>
            {
                new Articulo {Nombre = "Jabon", Precio = 18.9f, ID = 1},
                new Articulo {Nombre = "Mayonesa", Precio = 45.13f, ID =2 },
                new Articulo {Nombre = "Tomate", Precio = 49.00f, ID = 3},
                new Articulo {Nombre = "Carne", Precio = 98f, ID = 4},
                new Articulo {Nombre = "Huevo", Precio = 65f, ID = 5},
            };

        }
    }
}
