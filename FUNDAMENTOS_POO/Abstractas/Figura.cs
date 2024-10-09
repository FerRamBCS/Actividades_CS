using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO
{
    internal abstract class Figura
    {
       protected int Area { get; set; }
       protected int Perimetro { get; set; }
        public string UnidadMedida { get; set; }


        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();


        public void MuestraArea()
        {
            Console.WriteLine($"El area es: {Area} {UnidadMedida}");
        }
        public void MuestraPerimetro()
        {
            Console.WriteLine($"El perimetro es: {Perimetro} {UnidadMedida}");
        }

    }
}
