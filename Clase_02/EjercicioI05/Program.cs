using System;
using System.Text;


namespace EjercicioI05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tabla;
            int numeroEntero;

            Console.WriteLine("Ingrese un numero entero:");
            if(int.TryParse(Console.ReadLine(),out numeroEntero))
            {
                tabla = TablasDeMultiplicacion(numeroEntero);
            }
            else
            {
                tabla = "ERROR AL INGRESAR UN NUMERO ENTERO";
            }

            Console.WriteLine(tabla);
        }
        static string TablasDeMultiplicacion(int numero)
        {
            string modeloMensaje = "$ x % = &";
            StringBuilder tabla = new StringBuilder("Tabla de multiplicar del numero $:\n");
            int i;
            int resultado;
            //string tablaDeMultiplicacion;

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
                tabla.Replace("$", numeroStr);
                tabla.Replace("%", iStr);
                tabla.Replace("&", resultadoStr);

                /*for (int j = 0; j < tabla.Length; j++)
                {
                    if(tabla[j] == '$')
                    {
                        tabla[j] = numeroStr;
                        tabla.re
                    }
                }*/
            }

            //tablaDeMultiplicacion = Convert.ToString(tabla);
            //return tablaDeMultiplicacion;


            return tabla.ToString();

        }
    }
}
