using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO.Abstractas
{
    internal class Circulo : Figura
    {
        public int radio {  get; set; }
        public override void CalcularArea()
        {
            Area = ((int)(Math.PI * Math.Pow(radio, 2)));
        }

        public override void CalcularPerimetro()
        {
            Perimetro = (int)(2 * Math.PI * radio);
        }
    }
}
