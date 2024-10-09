using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO.Interfaces
{
    internal class Clase : iUSUARIO
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public bool ActualizarPerfil(string nombre, string Email)
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }
    }
}
