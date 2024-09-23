using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3en1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecciona el programa que deseas ejecutar:");
                Console.WriteLine("1. Operaciones (suma, resta, multiplicación, división)");
                Console.WriteLine("2. Ordenar tres números de mayor a menor");
                Console.WriteLine("3. Buscar números primos");
                Console.WriteLine("4. Determinar el mayor de una lista");
                Console.WriteLine("5. Salir");
                int seleccion = Convert.ToInt32(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:
                        RealizarOperaciones();
                        break;
                    case 2:
                        OrdenarNumeros();
                        break;
                    case 3:
                        BuscarNumerosPrimos();
                        break;
                    case 4:
                        mayorLista();
                        break;
                    case 5:
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\n¿Deseas realizar otra operación? (S/N)");
                    char respuesta = Char.ToUpper(Console.ReadKey().KeyChar);

                    if (respuesta != 'S')
                    {
                        continuar = false;
                        Console.WriteLine("\nSaliendo del programa...");
                    }
                    else
                    {
                        Console.Clear(); // Limpia la consola para empezar de nuevo
                    }
                }
            }

            // Evitar que la consola se cierre inmediatamente
            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }

        // Método para realizar operaciones
        static void RealizarOperaciones()
        {
            Console.WriteLine("\nIntroduce el primer número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona la operación que deseas realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El resultado de la suma es: " + (numero1 + numero2));
                    break;
                case 2:
                    Console.WriteLine("El resultado de la resta es: " + (numero1 - numero2));
                    break;
                case 3:
                    Console.WriteLine("El resultado de la multiplicación es: " + (numero1 * numero2));
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        Console.WriteLine("El resultado de la división es: " + (numero1 / numero2));
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Método para ordenar tres números de mayor a menor
        static void OrdenarNumeros()
        {
            Console.WriteLine("\nIntroduce el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double mayor, medio, menor;

            // Determinar el orden de mayor a menor
            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
                if (num2 >= num3)
                {
                    medio = num2;
                    menor = num3;
                }
                else
                {
                    medio = num3;
                    menor = num2;
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
                if (num1 >= num3)
                {
                    medio = num1;
                    menor = num3;
                }
                else
                {
                    medio = num3;
                    menor = num1;
                }
            }
            else
            {
                mayor = num3;
                if (num1 >= num2)
                {
                    medio = num1;
                    menor = num2;
                }
                else
                {
                    medio = num2;
                    menor = num1;
                }
            }

            Console.WriteLine($"El orden de mayor a menor es: {mayor}, {medio}, {menor}");
        }

        // Método para buscar números primos
        static void BuscarNumerosPrimos()
        {
            Console.WriteLine("\nIntroduce un número límite para buscar los números primos:");
            int limite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Los números primos hasta {limite} son:");

            for (int i = 2; i <= limite; i++)
            {
                if (EsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine(); // Salto de línea al final de los números primos
        }

        // Método auxiliar para verificar si un número es primo
        static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void mayorLista()
        {
            bool continuar = true;
            List<int> lista = new List<int>();
            while (continuar)
            {
                Console.WriteLine("Ingresa un numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);

                Console.WriteLine("¿Quieres agregar otro numero?");

                if (continuar)
                {
                    Console.WriteLine("\n¿Deseas realizar otra operación? (S/N)");
                    char respuesta = Char.ToUpper(Console.ReadKey().KeyChar);

                    if (respuesta != 'S')
                    {
                        continuar = false;
                        Console.WriteLine("\nSaliendo del programa...");
                    }
                    else
                    {
                        Console.Clear(); // Limpia la consola para empezar de nuevo
                    }
                }
            }
            bool esMayor = false;
            for (int i  = 0; i < lista.Count; i++)//For 1
            {
                int n = lista[i];//Obtiene numero de la lista
                for (int j = 0; j < lista.Count; j++)//For 2
                {
                    int m = lista[j]; //obtiene numero de FOR 2
                    if (n < m)
                    {
                        break;
                    }else if (n == m || n < j)
                    {
                        if (j == lista.Count - 1)
                        {
                            esMayor = true;
                        }
                    }
                    if (!esMayor)
                    {
                        break;
                    }
                }

            }

        }
    }
}
