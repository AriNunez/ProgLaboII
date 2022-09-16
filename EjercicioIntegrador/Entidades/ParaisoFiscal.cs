using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar):this()
        {
            this._lugar = lugar;
        }

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha de Inicio: {fechaInicioActividades.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Locación: {this._lugar}");
            sb.AppendLine($"Cantidad de 'cuentitas': {cantidadDeCuentas}");
            sb.AppendLine("**********Listado de cuentas offshore**********");

            foreach (CuentaOffShore item in this._listadoCuentas)
            {
                sb.Append(Cliente.RetornarDatos(item.Dueño));
                sb.AppendLine($"Número de cuenta: {(int)item}");
                sb.AppendLine($"Saldo: {item.Saldo}\n");
            }

            Console.WriteLine(sb.ToString());
        }

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }

        public static bool operator ==(ParaisoFiscal pf,CuentaOffShore cos)
        {
            bool retorno = false;
            if(pf is not null && cos is not null)
            {
                foreach (CuentaOffShore item in pf._listadoCuentas)
                {
                    if(item == cos)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }
        public static bool operator !=(ParaisoFiscal pf,CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if(pf is not null && cos is not null)
            {
                if(pf!=cos)
                {
                    pf._listadoCuentas.Add(cos);
                    cantidadDeCuentas++;
                    Console.WriteLine("Se agregó la cuenta al paraíso...");
                    return pf;
                }
                else
                {
                    foreach (CuentaOffShore item in pf._listadoCuentas)
                    {
                        if(item == cos)
                        {
                            item.Saldo = cos.Saldo;
                            Console.WriteLine("Se actualizó el saldo de la cuenta...");
                        }
                    }
                }
            }
            return pf;
        }
        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if(pf is not null && cos is not null)
            {
                if(pf == cos)
                {
                    foreach (CuentaOffShore item in pf._listadoCuentas)
                    {
                        if(item == cos)
                        {
                            pf._listadoCuentas.Remove(cos);
                            cantidadDeCuentas--;
                            Console.WriteLine("Se quito la cuenta del paraíso...");
                            return pf;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("La cuenta no existe en el paraíso...");
                }
            }

            return pf;
        }
    }
}
