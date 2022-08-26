using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_BIS
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.BackgroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            StringBuilder mensajeArmado = new StringBuilder();
            bool flagPrimeraLinea = false;

            for (int i = 0; i <= Sello.mensaje.Length+2; i++)
            {
                if(!flagPrimeraLinea && i == Sello.mensaje.Length+2)
                {
                    i = 0;
                    mensajeArmado.AppendLine($"\n*{Sello.mensaje}*");
                    flagPrimeraLinea=true;
                }else
                {
                    mensajeArmado.Append("*");
                }
            }

            return mensajeArmado.ToString();    
        }
    }
}
