using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioI02;
using Biblioteca;

namespace Pruebas
{
    [TestClass]
    public class IntExtensionTest
    {
        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasamosUno_DeberiaRetornarUno()
        {
            //Arrange

            long numero = 1;
            int expected = 1;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasamosCien_DeberiaRetornarTres()
        {
            //Arrange

            long numero = 100;
            int expected = 3;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoUnUnoNegativo_DeberiaRetornarUno()
        {
            //Arrange

            long numero = -1;
            int expected = 1;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public static int PedirNumero()
        {
            Console.Write("Ingrese un número: ");
            if(int.TryParse(Console.ReadLine(), out int numero))
            {
                return numero;
            }

            return 0;
        }
    }
}
