using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial:Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraria;

        public Provincial(Llamada llamada,Franja miFranja) 
        : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            franjaHoraria = miFranja;
        }

        public Provincial(float duracion, string nroDestino, string nroOrigen,Franja miFranja)
        : this(new Llamada(duracion, nroDestino, nroOrigen), miFranja)
        {
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Tipo de llamada: Provincial");
            sb.AppendLine($"Franja horaria: {franjaHoraria}");
            sb.AppendLine($"Costo de llamada: {CostoLlamada}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float costo = 0;
            switch(franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = duracion * 0.99F;
                    break;

                case Franja.Franja_2:
                    costo = duracion * 1.25F;
                    break;

                case Franja.Franja_3:
                    costo = duracion * 0.66F;
                    break;
            }
            return costo;
        }
    }
}
