using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class IntExtension
    {
        public static int ContarCantidadDeDigitos(this long numero)
        {

            string numeroStr = numero.ToString();

            numeroStr = numeroStr.Replace("-", "");

            return numeroStr.Length;
        }
    }
}
