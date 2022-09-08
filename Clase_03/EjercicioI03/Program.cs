using System;
using Entidades;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante primerEstudiante = new Estudiante("Pepe","1001","Argento");
            Estudiante segundoEstudiante = new Estudiante("Juan", "1002", "Ramirez");
            Estudiante tercerEstudiante = new Estudiante("Beto", "1003", "Perez");

            primerEstudiante.SetNotaPrimerParcial(9);
            primerEstudiante.SetNotaSegundoParcial(8); 
            
            segundoEstudiante.SetNotaPrimerParcial(6);
            segundoEstudiante.SetNotaSegundoParcial(10);

            tercerEstudiante.SetNotaPrimerParcial(3);
            tercerEstudiante.SetNotaSegundoParcial(5);

            Console.WriteLine(primerEstudiante.Mostrar());
            Console.WriteLine(segundoEstudiante.Mostrar());
            Console.WriteLine(tercerEstudiante.Mostrar());
        }
    }
}
