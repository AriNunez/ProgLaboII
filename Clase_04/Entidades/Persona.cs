using System;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private long dni;

        public Persona()
        {
            this.nombre = string.Empty;
            this.fechaDeNacimiento = new DateTime(1990, 1, 1);
            this.dni = 0;
        }

        public Persona(string nombre) : this()
        {
            this.nombre = nombre;
        }   
        public Persona(string nombre,DateTime fechaDeNacimiento) : this(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }   
        public Persona(string nombre,DateTime fechaDeNacimiento,long dni) : this(nombre,fechaDeNacimiento)
        {
            this.dni = dni;
        }

        //public Persona(string nombre, DateTime fechaDeNacimiento, long dni)
        //{
        //    this.nombre = nombre;
        //    this.fechaDeNacimiento = fechaDeNacimiento;
        //    this.dni = dni;
        //}

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento.ToString()}");
            sb.AppendLine($"Dni: {dni}");

            return sb.ToString();
        }

        public static bool operator ==(Persona p1,Persona p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.nombre == p2.nombre; 
            }

            return false;
        }        
        public static bool operator !=(Persona p1,Persona p2)
        {
            return !(p1 == p2);
        }

    }
}
