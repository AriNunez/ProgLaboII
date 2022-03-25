using System;
using EjercicioI01;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero:");

                if(int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    acumulador += numeroIngresado;
                }

            } while (Validador.ValidarRespuesta());

            Console.WriteLine("El resultado de la suma de los numeros ingresados es: {0}",acumulador);
            
        }
    }
}
