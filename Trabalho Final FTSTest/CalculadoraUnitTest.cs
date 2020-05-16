using System;
using System.Collections.Generic;
using System.Text;
using Trabalho_Final_FTS;
using Xunit;

namespace Trabalho_Final_FTSTest
{
    public class CalculadoraUnitTest
    {
        [Fact]
        public void Somar_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;
            // Act  
            var soma = Calculadora.Somar(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        public void Subtrair_DoisDouble_RetornaDouble()
        {

        }
        [Fact]
        public void Multiplicar_DoisDouble_RetornaDouble()
        {

        }
        [Fact]
        public void Dividir_DoisDouble_RetornaDouble()
        {
            Assert.Equal(4, Calculadora.Dividir(8, 2));
        }
        [Fact]
        public void Dividir_DivisaoPor0_RetornaErro()
        {
            Assert.Throws<DivideByZeroException>(() => Calculadora.Dividir(1, 0));
        }
    }
}
