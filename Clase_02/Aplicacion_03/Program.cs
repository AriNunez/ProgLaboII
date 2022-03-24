using System;

namespace Aplicacion_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] arrayStrings = { "2", "5", null, "gg3g3" };
            string[] arrayPalabras = new string[10];
            string[,] matrizPalabras = new string[10, 5];

            string input = "Ariel";

            Console.WriteLine(input[1]);

            string nombre = Funciones.NombreApp();
        }
    }
}
