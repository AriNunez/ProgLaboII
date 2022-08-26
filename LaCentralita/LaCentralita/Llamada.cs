using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get { return duracion; }
        }

        public string NroOrigen
        {
            get { return nroOrigen; }
        }

        public string NroDestino
        {
            get { return nroDestino; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion: {Duracion}");
            sb.AppendLine($"Numero de Destino: {NroDestino}");
            sb.AppendLine($"Numero de Origen: {NroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            return (int)(llamada1.Duracion - llamada2.Duracion);
        }
    }
}
