using System;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dividir(0);
            }
            catch (Exception error)
            {
                Console.WriteLine("Excepcion manejada");
                Console.WriteLine(error.Message);
            }
        }

        static void Dividir(int numero)
        {
            float resultado;

            resultado = 10 / numero;

            Console.WriteLine(resultado);
        }
    }
}
