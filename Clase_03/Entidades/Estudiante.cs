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

        //private static void Estudiante()
        //{
        //    random = new Random();

            

        //}

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
            //Estudiante();
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float promedio;

            promedio = this.notaPrimerParcial / this.notaSegundoParcial;

            return promedio;
        }

    }
}
