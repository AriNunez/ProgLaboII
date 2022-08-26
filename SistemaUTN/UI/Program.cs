using System;
using Logica;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(Sistema.CheckearUsuario("pepe","asd123"))
            {
                Console.WriteLine("Logueado");
            }
            else
            {
                Console.WriteLine("SIN ACCESO");
            }
        }
    }
}
