using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO
{
    // hereda de clase persona
    internal class Persona2 : Persona
    {
        public Persona2(string nombre, string email, int id)
        {
            Nombre = nombre;
            Email = email;
            Id = id;
            ImprimeId();
            ImprimiNombre();
            ImprimeEmail();
            ImprimeFecha();
        }
        public void ImprimeEmail()
        {
            Console.WriteLine(Email);

        }
    }
}
