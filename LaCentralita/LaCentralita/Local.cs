using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(float duracion, string nroDestino, string nroOrigen, float costo) : this(new Llamada(duracion, nroDestino, nroOrigen), costo)
        {
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costoCalculado = costo * Duracion;
            return costoCalculado;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Tipo de llamada: Local");
            sb.AppendLine($"Costo por minuto: {costo}");
            sb.AppendLine($"Costo de LLamda: {CostoLlamada}");

            return sb.ToString();
        }
    }
}
