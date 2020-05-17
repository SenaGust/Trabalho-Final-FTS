using System;
using System.Collections.Generic;
using System.Text;
using Trabalho_Final_FTS;
using Xunit;

namespace Trabalho_Final_FTSTest
{
    public class CalculadoraCientificaUnitTest
    {
        [Fact]
        [Trait("CalculadoraCientifica", "Cos")]
        public void Cos_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 2;
            double valorEsperado = -0.4161468365471424;
            // Act
            double soma = CalculadoraCientifica.Cos(num);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Cos")]
        public void Cos_DoubleNegativo_RetornaDouble()
        {
            // Arrange
            double num = -2;
            double valorEsperado = -0.4161468365471424;
            // Act
            double soma = CalculadoraCientifica.Cos(num);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Cos")]
        public void Cos_Zero_RetornaDouble()
        {
            // Arrange
            double num = 0;
            double valorEsperado = 1;
            // Act
            double soma = CalculadoraCientifica.Cos(num);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Potenciacao")]
        public void Potenciacao_DoublePositivoEZero_RetornaDouble()
        {
            // Arrange
            double num1 = 100;
            double num2 = 0;
            double valorEsperado = 1;
            // Act
            double soma = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Potenciacao")]
        public void Potenciacao_DoisDoublePositivos_RetornaDouble()
        {
            // Arrange
            double num1 = 5;
            double num2 = 4;
            double valorEsperado = 625;
            // Act
            double soma = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Potenciacao")]
        public void Potenciacao_DoisDoubleNegativos_RetornaDouble()
        {
            // Arrange
            double num1 = -5;
            double num2 = -4;
            double valorEsperado = 0.0016;
            // Act
            double soma = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Potenciacao")]
        public void Potenciacao_DoublePositivoENegativo_RetornaDouble()
        {
            // Arrange
            double num1 = 7;
            double num2 = -3;
            double valorEsperado = 0.0029154518950437317;
            // Act
            double soma = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Potenciacao")]
        public void Potenciacao_DoubleNegativoEPositivo_RetornaDouble()
        {
            // Arrange
            double num1 = -7;
            double num2 = 3;
            double valorEsperado = -343;
            // Act
            double soma = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Ln")]
        public void Ln_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 25;
            double valorEsperado = 3.2188758248682007492015186664524;
            // Act
            double soma = CalculadoraCientifica.Ln(num);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Ln")]
        public void Ln_DoubleNegativo_RetornaNaN()
        {
            // Arrange
            double num = -25;
            double valorEsperado = double.Parse("NaN");
            // Act
            double soma = CalculadoraCientifica.Ln(num);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Ln")]
        public void Ln_Zero_RetornaInfinito()
        {
            // Arrange
            double num = 0;
            double valorEsperado = double.Parse("-∞");
            // Act
            double soma = CalculadoraCientifica.Ln(num);
            //Assert
            Assert.Equal(valorEsperado, soma);
        }
    }
}
