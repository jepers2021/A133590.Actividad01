using System;
using System.Collections.Generic;
using System.Text;

namespace Consola
{
    class Ejercicio2
    {
        public static void resolver()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2.");
            Console.Write("Ingrese un texto cualquiera: ");
            string texto = Console.ReadLine();
            Console.WriteLine($"Su texto es: {texto}");
            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
