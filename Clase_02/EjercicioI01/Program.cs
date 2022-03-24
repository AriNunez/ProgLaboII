using System;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int minimo = int.MaxValue;
            int maximo = int. MinValue;
            float promedio;
            int acumulador = 0;
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100:");
                if(int.TryParse(Console.ReadLine(), out numeroIngresado) && Validador.Validar(numeroIngresado,-100,100))
                {
                    if (numeroIngresado < minimo)
                    {
                        minimo = numeroIngresado;
                    }
                    if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }

                    acumulador += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("ERROR! Debe ingresar un numero entre -100 y 100");
                    i--;
                }
            }

            if(i == 10)
            {
                promedio = (float)acumulador / i;
                Console.WriteLine("Valor maximo: {0} -- Valor minimo: {1} -- Promedio: {2}", maximo, minimo, promedio);
            }

        }
    }
}
