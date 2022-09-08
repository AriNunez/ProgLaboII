using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        static Estudiante()
        {
            random = new Random();
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float promedio;

            promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            return promedio;
        }

        public double CalcularNotaFinal()
        {
            if((this.notaPrimerParcial >= 4 && this.notaPrimerParcial <= 10)&&(this.notaSegundoParcial >= 4 && this.notaSegundoParcial <= 10))
            {
                return (Double)random.Next(6,10);
            }

            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = this.CalcularNotaFinal();

            sb.AppendLine("Datos del alumno:");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota del primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine($"Nota final: Alumno desaprobado");
            }

            return sb.ToString();
        }

    }
}
