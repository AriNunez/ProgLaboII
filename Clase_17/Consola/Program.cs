using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Persona> listaPersonas = PersonaAccesoDatos.Leer();

                foreach (Persona persona in listaPersonas)
                {
                    Console.WriteLine($"ID: {persona.Id} Nombre: {persona.Nombre}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
