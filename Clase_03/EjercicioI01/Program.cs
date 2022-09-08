using System;
using Entidades;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("UTN Avellaneda", 7000.25M);

            Console.WriteLine(cuenta.Mostrar());

            cuenta.Ingresar(2500.05M);

            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(3600);

            Console.WriteLine(cuenta.Mostrar());

        }
    }
}
