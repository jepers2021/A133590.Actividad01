using System;
using System.Collections.Generic;
using System.Text;

namespace Consola
{
    class Ejercicio6
    {
        public static void resolver()
        {
            Console.Clear();
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo cki;


            Console.WriteLine("Ejercicio 6.");
            Console.WriteLine("El programa lee las teclas presionadas hasta que se presiona SHIFT+CTRL+F");
            while (true)
            {
                cki = Console.ReadKey();
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0 && (cki.Modifiers & ConsoleModifiers.Control) != 0 && cki.Key == ConsoleKey.F) break;
            }

            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
