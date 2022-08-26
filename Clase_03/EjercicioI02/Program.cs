using System;
using Entidades;
namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pepe",new DateTime(1945,09,26),"1.450.812");
            Persona persona2 = new Persona("Charly",new DateTime(1988,10,14),"5.345.678");
            Persona persona3 = new Persona("Juan",new DateTime(2005,07,12),"44.453.789");

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());

            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.EsMayorDeEdad());
          
        }
    }
}
