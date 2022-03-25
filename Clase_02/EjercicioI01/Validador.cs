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

        public static bool ValidarRespuesta()
        {
            string confirmacion;
            bool retorno = false;

            do
            {
                Console.WriteLine("Desea continuar? S/N");

                confirmacion = Console.ReadLine();

                if(confirmacion == "S")
                {
                    retorno = true;
                   // return true;
                }
                else
                {
                    if(confirmacion == "N")
                    {
                        retorno = false;
                        //return false;
                    }
                }
                
            }while(confirmacion != "S" && confirmacion != "N");

            return retorno;
        }
    }
}
