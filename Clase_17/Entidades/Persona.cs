using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int id;

        public Persona(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Id
        {
            get { return id; }
        }
    }
}
