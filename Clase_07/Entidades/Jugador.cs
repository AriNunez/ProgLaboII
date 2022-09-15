using System;
using System.Text;

namespace Entidades
{
    public enum EPosicion
    {
        Arquero,
        Defensor,
        Mediocampista,
        Delantero
    }


    public class Jugador
    {
        private static int ultimoId;
        private int id;
        private string nombre;
        private string numeroCamiseta;
        private EPosicion posicion;
        //private string posicion;
        private int partidosJugados;

        static Jugador()
        {
            ultimoId = 1;
        }

        private Jugador()
        {
            this.nombre = "";
            this.numeroCamiseta = "0";
            //this.posicion = "";
            this.partidosJugados = 0;
        }

        public Jugador(string nombre,string numeroCamiseta,EPosicion posicion,int partidosJugados):this()
        {
            this.nombre = nombre;
            this.numeroCamiseta = numeroCamiseta;
            this.posicion = posicion;
            this.partidosJugados = partidosJugados;
            this.id = ultimoId;
            ultimoId++;
        }        
        //public Jugador(string nombre,string numeroCamiseta,string posicion,int partidosJugados):this()
        //{
        //    this.nombre = nombre;
        //    this.numeroCamiseta = numeroCamiseta;
        //    this.posicion = posicion;
        //    this.partidosJugados = partidosJugados;
        }

    //public string Mostrar()
    //{
    //    StringBuilder sb = new StringBuilder();
    //    sb.AppendLine($"Datos del jugador:");
    //    sb.AppendLine($"Nombre: {nombre}");
    //    sb.AppendLine($"Numero de Camiseta: {numeroCamiseta}");
    //    sb.AppendLine($"Posicion: {posicion}");
    //    sb.AppendLine($"Partidos Jugados: {partidosJugados.ToString()}");

    //    return sb.ToString();
    //}
}

