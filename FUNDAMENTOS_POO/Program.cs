using FUNDAMENTOS_POO.Abstractas;
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
            /*Persona2 p2 = new Persona2("Jose", "jfer1302@gmail.com", 1);
            Console.ReadLine();
            p2.Nombre = "RICARDO";
            p2.Email = "RICARDO@213gmail.com";
            p2.ImprimiNombre();
            p2.ImprimeEmail();
            p2.CambiarFecha(DateTime.Now);
            p2.ImprimeFecha();*/

            Console.WriteLine("Cuadrado");
            Cuadrado cuadrado = new Cuadrado()
            {
                MedirLado = 5,
                UnidadMedida = "Metros"
            };
            cuadrado.CalcularArea(); // Llamada antes de mostrar
            cuadrado.MuestraArea();
            cuadrado.CalcularPerimetro(); // Llamada antes de mostrar
            cuadrado.MuestraPerimetro();

            Console.WriteLine("Rectangulo");
            Rectangulo rectangulo = new Rectangulo()
            {
                Base = 10,
                Altura = 10,
                UnidadMedida = "Metros"
            };
            rectangulo.CalcularArea(); // Llamada antes de mostrar
            rectangulo.MuestraArea();
            rectangulo.CalcularPerimetro(); // Llamada antes de mostrar
            rectangulo.MuestraPerimetro();

            Console.WriteLine("Triangulo");
            Triangulo triangulo = new Triangulo()
            {
                Base = 10,
                Altura = 10,
                Lado1 = 10,
                Lado2 = 10,
                Lado3 = 10,
            };
            triangulo.CalcularArea();
            triangulo.MuestraArea();
            triangulo.CalcularPerimetro();
            triangulo.MuestraPerimetro();


            Console.WriteLine("Cuadrado");
            Circulo circulo = new Circulo()
            {
                radio = 10
            };
            circulo.CalcularArea();
            circulo.MuestraArea();
            circulo.CalcularPerimetro();
            circulo.MuestraPerimetro();

            Console.WriteLine("Poligono");
            Poligono poligono = new Poligono()
            {
                Lados = 10,
                Longitud = 10,
                Apotema = 10
            };
            poligono.CalcularPerimetro();
            poligono.CalcularArea();
            poligono.MuestraArea();
            poligono.MuestraPerimetro();

            Console.ReadLine();

        }
    }
}
