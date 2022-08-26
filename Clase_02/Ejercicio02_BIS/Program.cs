using System;

namespace Ejercicio02_BIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola mundo";

            //Console.WriteLine(Sello.Imprimir());

            //Sello.Borrar();

            //Console.WriteLine(Sello.Imprimir());

            //Sello.mensaje = "hola mundo C#";

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());
        }
    }
}
