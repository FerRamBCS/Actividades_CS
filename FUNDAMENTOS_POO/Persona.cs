using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO
{   
    //Clase principal que sera heredada
    class Persona
    {
        protected int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        private DateTime fechaCreacion {  get; set; }

        public void ImprimiNombre()
        {
            Console.WriteLine(Nombre);
        }
        protected void ImprimeId()
        {
            Console.WriteLine(Id);
        }
        public void ImprimeFecha()
        {
            Console.WriteLine(fechaCreacion);
        }
        public void CambiarFecha(DateTime Nuevafecha)
        {
            fechaCreacion = Nuevafecha;
        }
    }
}
