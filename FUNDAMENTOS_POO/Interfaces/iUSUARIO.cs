using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO
{
    internal interface iUSUARIO
    {
        string Nombre { get; set; }
        string Email { get; set; }
        void Login();
        bool ActualizarPerfil(string nombre, string Email);
    }
}
