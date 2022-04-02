using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

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
            if(int.TryParse)
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
            return this.dni
        }
    }
}
