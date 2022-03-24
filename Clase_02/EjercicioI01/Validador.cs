using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01
{
    public static class Validador
    {
        public static bool Validar (int valor,int min, int max)
        {
            bool retorno = false;

            if((min < max) && (valor >= min && valor <= max))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
