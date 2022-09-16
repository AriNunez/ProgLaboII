using System;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._aliasParaIncognito = "Sin alias";
            this._nombre = "NN";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoDeCliente) :this()
        {
            this._tipoDeCliente = tipoDeCliente;
        }

        public Cliente(eTipoCliente tipoDeCliente,string nombre):this(tipoDeCliente)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            Random rand = new Random();
            this._aliasParaIncognito = string.Concat(rand.Next(1000, 9999).ToString(), this._tipoDeCliente.ToString());
        }

        public string GetAlias()
        {
            if(this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }

            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this._nombre}");
            sb.AppendLine($"Tipo {this._tipoDeCliente}");
            sb.AppendLine($"Alias: {this.GetAlias()}");

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente unCliente)
        {
            if(unCliente is not null)
            {
                return unCliente.RetornarDatos();
            }

            return String.Empty;
        }
    }
}
