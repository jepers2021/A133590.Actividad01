using System;
using System.Collections.Generic;
using System.Text;

namespace Consola
{
    class Ejercicio4
    {
        public static void resolver()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 4.");
            Console.WriteLine("Ingrese frases separadas con la tecla enter.");
            Console.WriteLine("El programa finalizará cuando ingrese \"fin\"");

            while (Console.ReadLine() != "fin") ;

            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
