using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS_POO.Abstractas
{
    internal class Poligono : Figura
    {
        public int Lados {  get; set; }
        public int Longitud {  get; set; }
        public override void CalcularArea()
        {
            Area = (int)(Lados * Math.Pow(Longitud, 2) / 4 * Math.Tan(Math.PI / Lados));
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lados * Longitud;
        }
    }
}
