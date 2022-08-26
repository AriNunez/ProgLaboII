using System;
using Entidades;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(10,ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50,ConsoleColor.Red);
            string dibujoAzul;
            //string dibujoRojo;

            boligrafoAzul.Pintar(-20, out dibujoAzul);

            Console.ForegroundColor = boligrafoAzul.GetColor();
            Console.WriteLine(dibujoAzul);
            Console.WriteLine(boligrafoAzul.GetTinta());
            
        }
    }
}
