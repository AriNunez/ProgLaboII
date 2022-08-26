using Entidades;
using System;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();

            string resultadoString = sumador.Sumar("Hola", "mundo");

            Console.WriteLine($"Resultado string {resultadoString}");

            Console.WriteLine($"Cantidad sumas: {(int)sumador}");

            Sumador sumador2 = new Sumador();

            long resultadoLong = sumador.Sumar(15, 20);

            Console.WriteLine($"Resultado long: {resultadoLong}");

            Console.WriteLine($"Cantidad sumas: {(int)sumador}");

            Console.WriteLine($"Suma de sumadores: {sumador + sumador2}");
            Console.WriteLine($"Tiene la misma cantidad de sumas?: {sumador | sumador2}");

        }
    }
}
