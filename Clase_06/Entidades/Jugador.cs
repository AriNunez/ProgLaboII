using System;
using System.Text;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) :this()
        {
            this.dni= dni;
            this.nombre = nombre;
        }

        public Jugador(int dni,string nombre,int totalGoles,int totalPartidos) :this(dni,nombre)
        {
            this.totalGoles= totalGoles;
            this.partidosJugados= totalPartidos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del jugador:");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total goles: {totalGoles}");
            sb.AppendLine($"Promedio goles: {GetPromedioGoles().ToString()}");

            return sb.ToString();
        }

        private float GetPromedioGoles()
        {
            if(partidosJugados == 0)
            {
                return 0;
            }
            this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            return promedioGoles;
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if(jugador1 is not null &&  jugador2 is not null)
            {
                return jugador1.dni == jugador2.dni;
            }
            return false;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
