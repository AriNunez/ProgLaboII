using System;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosPerfectos = 0;
            //int numeroPerfecto;
            int i = 0;
            int j;
            int acumulador;
            int resto;


            do
            {
                acumulador = 0;
                for (j = 1; j <= i; j++)
                {
                    resto = i % j;
                    if (resto == 0 && j != i)
                    {
                        acumulador = acumulador + j;
                    }
                }

                if(acumulador == i && i > 1)
                {
                    Console.WriteLine(i);
                    numerosPerfectos++;
                }
                i++;
            } while (numerosPerfectos <= 4);
        }
    }
}
