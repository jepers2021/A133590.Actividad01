using System;
using System.Collections.Generic;
using System.Text;

namespace Consola
{
    class Ejercicio3
    {
        public static void resolver()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 3.");
            Console.WriteLine("El siguiente lee las teclas y finaliza al presionar la tecla \"x\".");
            while (Console.ReadKey().Key != ConsoleKey.X)
            {

            }
            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
