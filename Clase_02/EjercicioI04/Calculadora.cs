namespace EjercicioI04
{
    public static class Calculadora
    {
        public static double Calcular(double primerOperando, double segundoOperando, char operador)
        {
            double resultado = 0;


            switch (operador)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;

                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;

                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;

                case '/':
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        System.Console.WriteLine("No es posible dividir por 0!");
                    }
                    break;

                default:
                    System.Console.WriteLine("No se ha ingresado un operador valido!");
                    break;
            }
            return resultado;
        }

        private static bool Validar(double segundoOperando)
        {
            bool retorno = false;

            if (segundoOperando != 0)
            {
                retorno = true;
            }

            return retorno;
        }

        //public static double Suma(double primerOperando, double segundoOperando)
        //{

        //}public static double Resta(double primerOperando, double segundoOperando)
        //{

        //}public static double Multiplicacion(double primerOperando, double segundoOperando)
        //{

        //}public static double Division(double primerOperando, double segundoOperando)
        //{

        //}
    }
}
