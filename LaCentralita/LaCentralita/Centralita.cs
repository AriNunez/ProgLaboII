using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local); }
        }        
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }        
        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }        
        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (var item in listaDeLlamadas)
            {
                if (item is Local variableLocal)
                {
                    gananciaLocal += variableLocal.CostoLlamada;
                }
                else if (item is Provincial variableProvincial)
                {
                    gananciaProvincial += variableProvincial.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return gananciaLocal;
                case Llamada.TipoLlamada.Provincial:
                    return gananciaProvincial;
                default:
                    return gananciaLocal + gananciaProvincial;
            }


            #region codigoViejo

            //float ganancia = 0;
            //if(tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
            //{
            //    foreach(Llamada llamada in listaDeLlamada)
            //    {
            //        if(llamada is Local llamadaLocal) // esto me hace un casteo al tipo derivado
            //        {
            //            ganancia += llamadaLocal.CostoLlamada;
            //        }
            //    }
            //}

            //if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
            //{
            //    foreach (Llamada llamada in listaDeLlamada)
            //    {
            //        if (llamada is Provincial llamadaProvincial)// esto me hace un casteo al tipo derivado
            //        {
            //            ganancia += llamadaProvincial.CostoLlamada;
            //        }
            //    }
            //}

            //return ganancia;
            #endregion
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {razonSocial}");
            sb.AppendLine($"Ganancia Local: {GananciasPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {GananciasPorProvincial}");
            sb.AppendLine($"Ganancia Total: {GananciasPorTotal}\n");
            sb.AppendLine($"Lista de llamadas:\n");
            foreach (var item in listaDeLlamadas)
            {
                if (item is Local llamadaLocal)
                {
                    sb.AppendLine(llamadaLocal.Mostrar());
                }
                else if (item is Provincial llamadaProvincial)
                {
                    sb.AppendLine(llamadaProvincial.Mostrar());
                }
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
