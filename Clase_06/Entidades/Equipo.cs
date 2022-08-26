using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private string nombre;
        private short cantidadDeJugadores;
        private static string edad;
        List<Jugador> jugadores;

        static Equipo()
        {
            jugadores = new List<Jugador>();
            this.nombre = "Ariel";
            edad = "12";
        }
        //private Equipo()
        //{
            
        //}

        public Equipo(string nombre,short cantidadDeJugadores):this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
            edad = "12";
        }

        public static bool operator +(Equipo equipo,Jugador jugador)
        {
            if(equipo.jugadores.Count() < equipo.cantidadDeJugadores)
            {
                foreach(Jugador jug in equipo.jugadores)
                {
                    if(jug == jugador)
                    {
                        return false;
                    }
                }
            }
            
            return true;
            
            //if(equipo != null && jugador != null)
            //{
            //          Contains compara por instancia creo, es mejor hacerlo de la otra forma
            //    if(!equipo.jugadores.Contains(jugador))
            //    {
            //        equipo.jugadores.Add(j);
            //        equipo.cantidadDeJugadores++;
            //        return true;
            //    }
            //}
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Datos del equipo:");
            sb.Append($"Nombre: {nombre}");
            sb.Append($"Cantidad de Jugadores: {cantidadDeJugadores}");

            return sb.ToString();
        }

        private string Mostrar(string nombre)
        {
            return nombre;
        }
    }    
}
