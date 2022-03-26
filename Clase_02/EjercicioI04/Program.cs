using System;
using EjercicioI01;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primerOperando;
            double segundoOperando;
            double resultado;
            char operador;

            do
            {
                Console.WriteLine("Ingrese el primer operando:");
                if(double.TryParse(Console.ReadLine(), out primerOperando))
                {
                    Console.WriteLine("Ingrese el segundo operando:");
                    if(double.TryParse(Console.ReadLine(),out segundoOperando))
                    {
                        Console.WriteLine("Ingrese un operador (+ - * /):");
                        if(char.TryParse(Console.ReadLine(),out operador))
                        {
                            resultado = Calculadora.Calcular(primerOperando, segundoOperando, operador);
                            Console.WriteLine(resultado);
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }

            } while (Validador.ValidarRespuesta());
        }
    }
}
