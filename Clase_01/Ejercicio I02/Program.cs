using System;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
             * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/

            double numeroIngresado;
            string numeroIngresadoStr;
            double numeroAlCuadrado;
            double numeroAlCubo;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese un numero:");
                numeroIngresadoStr = Console.ReadLine();
                

                if(double.TryParse(numeroIngresadoStr, out numeroIngresado) && numeroIngresado > 0)
                {
                    numeroAlCuadrado = Math.Pow(numeroIngresado, 2);
                    numeroAlCubo = Math.Pow(numeroIngresado, 3);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero ingresado: {0} -- Cuadrado del numero: {1} -- Cubo del numero: {2}",numeroIngresado,numeroAlCuadrado,numeroAlCubo);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            }while(true);

        }
    }
}
