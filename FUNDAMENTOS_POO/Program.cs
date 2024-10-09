using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona2 p2 = new Persona2("Jose", "jfer1302@gmail.com", 1);
            Console.ReadLine();
            p2.Nombre = "RICARDO";
            p2.Email = "RICARDO@213gmail.com";
            p2.ImprimiNombre();
            p2.ImprimeEmail();
            p2.CambiarFecha(DateTime.Now);
            p2.ImprimeFecha();
            Console.ReadLine();

        }
    }
}
