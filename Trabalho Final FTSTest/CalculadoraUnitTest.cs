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
        [Trait("Calculadora", "Somar")]
        public void Somar_DoisDoublePositivos_RetornaInt()
        {
            // Arrange
            double num1 = 2.9;
            double num2 = 3.1;
            double valorEsperado = 6;
            // Act
            double soma = Calculadora.Somar(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("Calculadora", "Somar")]
        public void Somar_DoisDoubleNegativos_RetornaInt()
        {
            // Arrange
            double num1 = -2.9;
            double num2 = -3.1;
            double valorEsperado = -6;
            // Act  
            double soma = Calculadora.Somar(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("Calculadora", "Somar")]
        public void Somar_PositivoNegativo_RetornaInt()
        {
            // Arrange
            double num1 = 2.9;
            double num2 = -3.1;
            double valorEsperado = -0.2;
            // Act  
            double soma = Calculadora.Somar(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("Calculadora", "Subtrair")]
        public void Subtrair_DoisDouble_RetornaDouble()
        {
            // Arrange  
            double num1 = 3;
            double num2 = 1;
            double valorEsperado = 2;
            // Act  
            double soma = Calculadora.Subtrair(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("Calculadora", "Multiplicar")]
        public void Multiplicar_DoisDouble_RetornaDouble()
        {
            //Arrange
            double num1 = 2;
            double num2 = 3;
            double valorEsperado = 6;

            //Act
            double multiplicar = Calculadora.Multiplicar(num1, num2);

            //Assert
            Assert.Equal(valorEsperado, multiplicar);
            
        }
        [Fact]
        [Trait("Calculadora", "Dividir")]
        public void Dividir_DoisDouble_RetornaDouble()
        {
            Assert.Equal(4, Calculadora.Dividir(8, 2));
        }
        [Fact]
        [Trait("Calculadora", "Dividir")]
        public void Dividir_DivisaoPor0_RetornaErro()
        {
            Assert.Throws<DivideByZeroException>(() => Calculadora.Dividir(1, 0));
        }
    }
}
