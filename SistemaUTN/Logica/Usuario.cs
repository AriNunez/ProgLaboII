using System;

/*
 */

namespace Logica
{
    public class Usuario
    {
        private string nombre;
        private string password;

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public bool CheckPassword(string password)
        {
            return password == this.password;
        }

        internal void ModificarContra(string password)
        {
            this.password = password;
        }
    }
}
