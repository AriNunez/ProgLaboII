using System;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio IO1 :
            /*Ingresar 5 números por consola, guardándolos en una variable escalar.
             *Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/

            int numeroIngresado;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int acumulador = 0;
            float promedio;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");

                if(int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    if(numeroIngresado < minimo)
                    {
                        minimo = numeroIngresado;
                    }
                    if(numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }

                    acumulador += numeroIngresado;
                }
                else
                {
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Error!");
                  break;
                }
            }

            if (i == 5)
            {
                promedio = (float)acumulador / i;
                Console.WriteLine("Valor maximo: {0} -- Valor minimo: {1} -- Promedio: {2}", maximo, minimo, promedio);
            }











            //int numeroIngresado;
            ////string numeroIngresadoStr;
            //int valorMaximo = int.MinValue;
            //int valorMinimo = int.MaxValue;
            //int acumulador = 0;
            //float promedio;
            //bool flagMaximo = false;
            //bool flagMinimo = false;
            //int i;

            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    //numeroIngresadoStr = Console.ReadLine();

            //    //if (int.TryParse(numeroIngresadoStr, out numeroIngresado))
            //    if (int.TryParse(Console.ReadLine(), out numeroIngresado))
            //    {
            //        if (flagMaximo == false && flagMinimo == false)
            //        {
            //            valorMaximo = numeroIngresado;
            //            valorMinimo = numeroIngresado;
            //            flagMaximo = true;
            //            flagMinimo = true;
            //        }
            //        else
            //        {
            //            if (numeroIngresado > valorMaximo)
            //            {
            //                valorMaximo = numeroIngresado;
            //            }
            //            else
            //            {
            //                if (numeroIngresado < valorMinimo)
            //                {
            //                    valorMinimo = numeroIngresado;
            //                }
            //            }
            //        }
            //        acumulador += numeroIngresado;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Error!");
            //        break;
            //    }

            //}

            //if (i == 5)
            //{
            //    promedio = (float)acumulador / i;
            //    Console.WriteLine("Valor maximo: {0} -- Valor minimo: {1} -- Promedio: {2}", valorMaximo, valorMinimo, promedio);
            //}
            //else
            //{
            //    Console.WriteLine("hola");
            //}

        }
    }
}
