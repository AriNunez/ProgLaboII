using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                //if (this != value)
                //{
                //    clientes.Enqueue(value);
                //}
                _ = this + value;
            }
        }

        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            if (negocio is not null && cliente is not null)
            {
                if (negocio.clientes.Contains(cliente))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }

        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            if (negocio is not null && cliente is not null)
            {
                if (negocio != cliente)
                {
                    negocio.clientes.Enqueue(cliente);
                    return true;
                }
            }

            return false;
        }

        public static bool operator ~(Negocio negocio)
        {
            if(negocio is not null && negocio.ClientesPendientes > 0)
            {
                negocio.caja.Atender(negocio.Cliente);
                return true;
            }

            return false;
        }

    }
}
