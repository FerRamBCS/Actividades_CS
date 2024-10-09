using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO.Abstractas
{
    internal class Triangulo : Figura
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }

        public override void CalcularArea()
        {
            Area = (Base * Altura) / 2;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lado1 + Lado2 + Lado3;
        }
    }
}
