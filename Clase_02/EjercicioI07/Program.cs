using System;

namespace EjercicioI07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo = 7;
            double alturaTriangulo = 10;
            double hipotenusa;

            hipotenusa = CalcularHipotenusa(baseTriangulo, alturaTriangulo);

            Console.WriteLine("La hipotenusa de un triangulo de {0}cm de base y {1}cm de altura es {2}",baseTriangulo,alturaTriangulo,hipotenusa);
        }

        static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            double resultado;

            resultado = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));

            return resultado;
        }
    }
}
