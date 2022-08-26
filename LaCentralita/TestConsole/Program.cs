using System;
using Centralita;

namespace TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita.Centralita c = new Centralita.Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local( 30, "Rosario", "Bernal", 2.65F);
            Provincial l2 = new Provincial( 21, "Bernal","Morón", Provincial.Franja.Franja_1);
            Local l3 = new Local( 45, "San Rafael", "Lanús", 1.99f);
            Provincial l4 = new Provincial(l2, Provincial.Franja.Franja_3);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();

            c.Llamadas.Add(l2);
            Console.Clear();
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();

            c.Llamadas.Add(l3);
            Console.Clear();
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();

            c.Llamadas.Add(l4);
            Console.Clear();
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();

            c.OrdenarLlamadas();
            Console.Clear();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
