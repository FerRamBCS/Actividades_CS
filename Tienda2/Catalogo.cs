using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda2;

namespace Tienda2
{
    class Catalogo
    {
        private static List<Articulo> Inventario { get; set; }

        private static void llenarCatalogo()
        {
            Inventario = new List<Articulo>
            {
                new Articulo {Nombre = "Jabon", Precio = 18.9f, ID = 1},
                new Articulo {Nombre = "Mayonesa", Precio = 45.13f, ID = 2},
                new Articulo {Nombre = "Tomate", Precio = 49.00f, ID = 3},
                new Articulo {Nombre = "Carne", Precio = 98f, ID = 4},
                new Articulo {Nombre = "Huevo", Precio = 65f, ID = 5},
                new Articulo {Nombre = "Arroz", Precio = 25.50f, ID = 6},
                new Articulo {Nombre = "Azucar", Precio = 30.0f, ID = 7},
                new Articulo {Nombre = "Café", Precio = 85.0f, ID = 8},
                new Articulo {Nombre = "Leche", Precio = 24.5f, ID = 9},
                new Articulo {Nombre = "Pan de caja", Precio = 34.0f, ID = 10},
                new Articulo {Nombre = "Pasta", Precio = 16.75f, ID = 11},
                new Articulo {Nombre = "Aceite", Precio = 49.99f, ID = 12},
                new Articulo {Nombre = "Atún", Precio = 22.50f, ID = 13},
                new Articulo {Nombre = "Galletas", Precio = 19.99f, ID = 14},
                new Articulo {Nombre = "Refresco", Precio = 15.0f, ID = 15},
                new Articulo {Nombre = "Cereal", Precio = 40.0f, ID = 16},
                new Articulo {Nombre = "Yogurt", Precio = 20.5f, ID = 17},
                new Articulo {Nombre = "Queso", Precio = 58.9f, ID = 18},
                new Articulo {Nombre = "Mantequilla", Precio = 32.0f, ID = 19},
                new Articulo {Nombre = "Jugo de naranja", Precio = 28.0f, ID = 20},
                new Articulo {Nombre = "Cerveza", Precio = 50.0f, ID = 21},
                new Articulo {Nombre = "Vino", Precio = 120.0f, ID = 22},
                new Articulo {Nombre = "Papel higiénico", Precio = 60.0f, ID = 23},
                new Articulo {Nombre = "Detergente", Precio = 75.0f, ID = 24},
                new Articulo {Nombre = "Desodorante", Precio = 45.0f, ID = 25},
                new Articulo {Nombre = "Pasta dental", Precio = 30.0f, ID = 26},
                new Articulo {Nombre = "Jabón de manos", Precio = 25.0f, ID = 27},
                new Articulo {Nombre = "Esponja de baño", Precio = 10.0f, ID = 28},
                new Articulo {Nombre = "Crema corporal", Precio = 55.0f, ID = 29},
                new Articulo {Nombre = "Shampoo", Precio = 70.0f, ID = 30},
            };
        }

        public static void mostrarCatalogo()
        {
            llenarCatalogo();
            Console.WriteLine("\n********* Catálogo de Productos *********");
            Console.WriteLine($"{"ID",-5} {"Nombre",-20} {"Precio",-10}");
            Console.WriteLine("-----------------------------------------");

            foreach (Articulo articulo in Inventario)
            {
                Console.WriteLine($"{articulo.ID,-5} {articulo.Nombre,-20} ${articulo.Precio,8:F2}");
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Fecha: {DateTime.Now: dd/MM/yyyy hh:mm:ss tt}");
        }

        public static Articulo buscarArticuloId(int artId)
        {
            return Inventario.Find(x => x.ID.Equals(artId));
        }
    }
}