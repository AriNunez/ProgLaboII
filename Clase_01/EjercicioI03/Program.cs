using System;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            //Validar que el dato ingresado por el usuario sea un número.
            //Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            //Si ingresa "salir", cerrar la consola.
            //Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.

            int numeroIngresado = 20;
            //int numeroPrimo;
            int acumuladorDivisiones;
            int resto;
            int i;
            int j;

            for(i = 1; i <= numeroIngresado; i++)
            {
                acumuladorDivisiones = 0;

                for (j = 1; j <= i; j++)
                {
                    resto = i % j;
                    if(resto == 0)
                    {
                        acumuladorDivisiones++;
                    }
                }
                if(acumuladorDivisiones == 2)
                {
                    Console.WriteLine(i);
                }
            }
            
            
        }
    }
}
