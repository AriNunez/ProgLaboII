using System;
using Biblioteca;

namespace EjercicioI02
{
    public static class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número: ");
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out Int64 number))
                {
                    int cantidadDigitos = number.ContarCantidadDeDigitos();
                    Console.WriteLine("Número de {0,10} dígitos",cantidadDigitos);
                }
                else
                {
                    Console.WriteLine("Valor ingresado inválido");
                }

            }
        }


    }
}
