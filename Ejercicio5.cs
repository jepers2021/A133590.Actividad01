using System;
using System.Collections.Generic;
using System.Text;

namespace Consola
{
    class Ejercicio5
    {
        public static void resolver()
        {
            Console.Clear();
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo cki;


            Console.WriteLine("Ejercicio 5.");
            Console.WriteLine("El programa lee las teclas presionadas hasta que se presiona CTRL+F");
            while (true)
            {
                cki = Console.ReadKey();
                //if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) modificador = "SHIFT+";
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0 && cki.Key == ConsoleKey.F) break;
            }

            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
