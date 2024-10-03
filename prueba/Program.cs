using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> precios = new List<int> { 5, 3, 4, 7 };
            int totalSuma = sumarPrecios(precios);
            Console.WriteLine($"Suma total: {totalSuma}");
            Console.ReadKey();
        }
        static int sumarPrecios(List<int> precios)
        {
            int sum = 0;
            for(int i = 1; i < precios.Count; i++)
            {
                sum += sum + precios[i];
            }
            return sum;
        }
    }
}
