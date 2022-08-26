using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre,DateTime fechaDeNacimiento,string dni)
        {
            SetNombre(nombre);
            SetFechaDeNacimiento(fechaDeNacimiento);
            SetDni(dni);
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public string GetDni()
        {
            return this.dni;
        }

        private int CalcularEdad()
        {
            int edad;

            edad = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;

            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de persona:");
            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Fecha de nacimiento: {GetFechaDeNacimiento().ToString("dd/MM/yyyy")}");
            sb.AppendLine($"DNI: {GetDni()}");
            sb.AppendLine($"Edad: {CalcularEdad().ToString()}");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            int edad;

            edad = CalcularEdad();

            if(edad > 17)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }
    }
}
