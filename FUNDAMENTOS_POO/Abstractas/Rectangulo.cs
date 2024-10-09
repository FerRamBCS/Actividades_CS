using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO.Abstractas
{
    internal class Rectangulo : Figura
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public override void CalcularArea()
        {
            Area = Base * Altura;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 2 * (Base + Altura);
        }
    }
}
