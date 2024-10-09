using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO.Interfaces
{
    internal class Admin : iUSUARIO
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Nivel { get; set; }

        public bool ActualizarPerfil(string nombre, string Email)
        {
            return true;
        }

        public void Login()
        {
            Console.WriteLine("Usuario Loggeado");
        }
    }
}
