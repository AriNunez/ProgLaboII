using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioI05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tabla = TablasDeMultiplicacion(7);
            Console.WriteLine(tabla);


            static string TablasDeMultiplicacion(int numero)
            {
                string modeloMensaje = "$ x % = &";
                StringBuilder tabla = new StringBuilder("Tabla de multiplicar del numero $:\n");
                int i;
                int resultado;
                string tablaDeMultiplicacion;

                string resultadoStr;
                string iStr;
                string numeroStr;
                
                for (i = 1; i <= 10; i++)
                {
                    resultado = numero * i;
                    resultadoStr = Convert.ToString(resultado);
                    iStr = Convert.ToString(i);
                    numeroStr = Convert.ToString(numero);

                    tabla.AppendLine(modeloMensaje);
                    tabla.Replace("$",numeroStr);
                    tabla.Replace("%",iStr);
                    tabla.Replace("&",resultadoStr);
                    
                    /*for (int j = 0; j < tabla.Length; j++)
                    {
                        if(tabla[j] == '$')
                        {
                            tabla[j] = numeroStr;
                            tabla.re
                        }
                    }*/
                }

                tablaDeMultiplicacion = Convert.ToString(tabla);
                return tablaDeMultiplicacion;

            }
            

        }
    }
}
