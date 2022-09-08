using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de la cuenta:");
            sb.AppendLine($"Titular: {GetTitular()}");
            sb.AppendLine($"Cantidad: {GetCantidad()}");

            return sb.ToString();
        }
        public void Ingresar(decimal cantidadAIngresar)
        {
            if (cantidad > 0)
            {
                cantidad += cantidadAIngresar;
            }
        }

        public void Retirar(decimal cantidadARetirar)
        {
            cantidad -= cantidadARetirar;
        }
    }
}
