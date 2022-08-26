using System;
using Entidades;

namespace EjercicioC01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador(1111,"Ariel",15,6);
            Jugador jugador2 = new Jugador(1111,"Pepe",25,3);
            Jugador jugador3 = new Jugador(1333,"Juan",10,4);
            Jugador jugador4 = new Jugador(1444,"Rodri",35,12);
            Jugador jugador5 = new Jugador(1555,"Manu",100,3);

            Equipo equipo1 = new Equipo("Arsenal",1);
            Equipo equipo2 = new Equipo("Boca",5);

            Console.WriteLine(jugador1.Mostrar());
            Console.WriteLine(jugador5.Mostrar());

            if(equipo1 + jugador2)
            {
                Console.WriteLine($"Jugador agregado: {jugador2.Mostrar()}");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }
            if(equipo1 + jugador3)
            {
                Console.WriteLine($"Jugador agregado: {jugador3.Mostrar()}");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }



        }
    }
}
