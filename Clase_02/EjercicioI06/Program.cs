using System;

namespace EjercicioI06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double longitudLado;
            //double Base;
            //double altura;
            //double radio;

            Console.WriteLine("Area de un cuadrado con longitud de lado 5: {0}cm3",CalculadoraDeArea.CalcularAreaCuadrado(5));

            Console.WriteLine("Area de un triangulo de base 2 y altura 3: {0}cm3",CalculadoraDeArea.CalcularAreaTriangulo(2,3));

            Console.WriteLine("Area de un circulo de radio 3: {0}cm3",CalculadoraDeArea.CalcularAreaCirculo(3));

        }
    }
}
