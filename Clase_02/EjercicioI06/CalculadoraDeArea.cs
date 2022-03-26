using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI06
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado;

            areaCuadrado = longitudLado * 2;

            //areaCuadrado = Math.Pow(longitudLado,2);

            return areaCuadrado;
        }

        public static double CalcularAreaTriangulo(double Base, double altura)
        {
            double areaTriangulo;

            areaTriangulo = (Base * altura) / 2;

            return areaTriangulo;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double areaCirculo;

            areaCirculo = radio * radio * Math.PI;

            areaCirculo = Math.Pow(radio, 2) * Math.PI;

            return areaCirculo;
        }
    }
}
