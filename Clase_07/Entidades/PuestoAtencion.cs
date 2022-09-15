using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum EPuesto
        {
            Caja1,Caja2
        }

        private static int numeroActual;
        private EPuesto puesto;

        public int NumeroActual
        {
            get 
            {
                numeroActual++;
                return numeroActual; 
            }
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cliente)
        {
            Thread.Sleep(2000);
            return true;
        }
    }
}
