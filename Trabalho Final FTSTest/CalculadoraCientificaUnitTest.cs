using System;
using System.Collections.Generic;
using System.Text;
using Trabalho_Final_FTS;
using Xunit;

namespace Trabalho_Final_FTSTest
{
    public class CalculadoraCientificaUnitTest
    {

        #region Logaritmo
        [Fact]
        [Trait("CalculadoraCientifica", "Logaritmo")]
        public void Logaritmo_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 4.5;
            double valorEsperado = 0.6532;

            // Act
            double sen = CalculadoraCientifica.Logaritmo(num);

            //Assert
            Assert.Equal(valorEsperado, sen);
        }

        [Fact]
        [Trait("CalculadoraCientifica", "Logaritmo")]
        public void Logaritmo_DoubleIgualZero_RetornaInfinitoNegativo()
        {
            // Arrange
            double num = 0;
            double valorEsperado = double.NegativeInfinity;

            // Act
            double sen = CalculadoraCientifica.Logaritmo(num);

            //Assert
            Assert.Equal(valorEsperado, sen);
        }

        [Fact]
        [Trait("CalculadoraCientifica", "Logaritmo")]
        public void Logaritmo_DoubleNegativo_RetornaNaoEhNum()
        {
            // Arrange
            double num = -1.5;
            double valorEsperado = double.NaN;

            // Act
            double sen = CalculadoraCientifica.Logaritmo(num);

            //Assert
            Assert.Equal(valorEsperado, sen);
        }
        #endregion

        #region Seno
        [Fact]
        [Trait("CalculadoraCientifica", "Sen")]
        public void Sen_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 2;
            double valorEsperado = 0.0349;

            // Act
            double sen = CalculadoraCientifica.Sen(num);

            //Assert
            Assert.Equal(valorEsperado, sen);

        }

        [Fact]
        [Trait("CalculadoraCientifica", "Sen")]
        public void Sen_DoubleNegativo_RetornaDouble()
        {
            // Arrange
            double num = -2;
            double valorEsperado = -0.0349;

            // Act
            double sen = CalculadoraCientifica.Sen(num);

            //Assert
            Assert.Equal(valorEsperado, sen);
        }

        [Fact]
        [Trait("CalculadoraCientifica", "Sen")]
        public void Sen_Zero_RetornaDouble()
        {
            // Arrange
            double num = 0;
            double valorEsperado = 0;

            // Act
            double sen = CalculadoraCientifica.Sen(num);

            //Assert
            Assert.Equal(valorEsperado, sen);
        }
        #endregion

        #region Cosseno
        [Fact]
        [Trait("CalculadoraCientifica", "Cos")]
        public void Cos_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 2;
            double valorEsperado = 0.9994;
            // Act
            double valorObtido = CalculadoraCientifica.Cos(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Cos")]
        public void Cos_DoubleNegativo_RetornaDouble()
        {
            // Arrange
            double num = -2;
            double valorEsperado = 0.9994;
            // Act
            double valorObtido = CalculadoraCientifica.Cos(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Cos")]
        public void Cos_Zero_RetornaDouble()
        {
            // Arrange
            double num = 0;
            double valorEsperado = 1;
            // Act
            double valorObtido = CalculadoraCientifica.Cos(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        #endregion

        #region Tangente
        [Fact]
        [Trait("CalculadoraCientifica", "Tan")]
        public void Tan_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 45;
            double valorEsperado = 1;
            // Act
            double valorObtido = CalculadoraCientifica.Tan(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Tan")]
        public void Tan_DoubleNegativo_RetornaDouble()
        {
            // Arrange
            double num = -45;
            double valorEsperado = -1;
            // Act
            double valorObtido = CalculadoraCientifica.Tan(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Tan")]
        public void Tan_DoubleIgualZero_RetornaDouble()
        {
            // Arrange
            double num = 0;
            double valorEsperado = 0;
            // Act
            double valorObtido = CalculadoraCientifica.Tan(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        #endregion

        #region Radiciação
        [Fact]
        [Trait("CalculadoraCientifica", "Radiciacao")]
        public void Radiciacao_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 72;
            double valorEsperado = 8.4853;

            // Act
            double radiciacao = CalculadoraCientifica.Radiciacao(num);

            //Assert
            Assert.Equal(valorEsperado, radiciacao);

        }

        [Fact]
        [Trait("CalculadoraCientifica", "Radiciacao")]
        public void Radiciacao_DoubleNegativo_RetornaErro()
        {
            //Arrange
            double num = -72;
            double valorEsperado = double.NaN;
            //Act 
            double radiciacao = CalculadoraCientifica.Radiciacao(num);

            //Assert
            Assert.Equal(valorEsperado, radiciacao);
        }

        [Fact]
        [Trait("CalculadoraCientifica", "Radiciacao")]
        public void Radiciacao_zero_RetornaDouble()
        {
            // Arrange
            double num = 0;
            double valorEsperado = 0;

            // Act
            double radiciacao = CalculadoraCientifica.Radiciacao(num);

            //Assert
            Assert.Equal(valorEsperado, radiciacao);

        }
        #endregion

        #region Potenciação
        [Fact]
        [Trait("CalculadoraCientifica", "Potenciacao")]
        public void Potenciacao_DoublePositivoEZero_RetornaDouble()
        {
            // Arrange
            double num1 = 100;
            double num2 = 0;
            double valorEsperado = 1;
            // Act
            double valorObtido = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
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
            double valorObtido = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
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
            double valorObtido = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Potenciacao")]
        public void Potenciacao_DoublePositivoENegativo_RetornaDouble()
        {
            // Arrange
            double num1 = 7;
            double num2 = -3;
            double valorEsperado = 0.0029;
            // Act
            double valorObtido = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
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
            double valorObtido = CalculadoraCientifica.Potenciacao(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        #endregion

        #region Porcentagem
        [Fact]
        [Trait("CalculadoraCientifica", "Porcentagem")]
        public void Porcentagem_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 25.5;
            double valorEsperado = 0.255;
            // Act
            double valorObtido = CalculadoraCientifica.Porcentagem(num);
            // Assert
            Assert.Equal(valorEsperado, valorEsperado);
        }

        [Fact]
        [Trait("CalculadoraCientifica", "Porcentagem")]
        public void Porcentagem_DoubleNegativo_RetornaDouble()
        {
            // Arrange
            double num = -25.5;
            double valorEsperado = -0.255;
            // Act
            double valorObtido = CalculadoraCientifica.Porcentagem(num);
            // Assert
            Assert.Equal(valorEsperado, valorEsperado);
        }

        #endregion

        #region Pi
        [Fact]
        public void Pi_RetornaDouble()
        {
            // Arrange
            double valorEsperado = 3.14159265359;

            // Act
            double pi = CalculadoraCientifica.Pi();

            //Assert
            Assert.Equal(valorEsperado, pi);

        }
        #endregion

        #region Ln
        [Fact]
        [Trait("CalculadoraCientifica", "Ln")]
        public void Ln_DoublePositivo_RetornaDouble()
        {
            // Arrange
            double num = 25;
            double valorEsperado = 3.2189;
            // Act
            double valorObtido = CalculadoraCientifica.Ln(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Ln")]
        public void Ln_DoubleNegativo_RetornaNaN()
        {
            // Arrange
            double num = -25;
            double valorEsperado = double.Parse("NaN");
            // Act
            double valorObtido = CalculadoraCientifica.Ln(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        [Trait("CalculadoraCientifica", "Ln")]
        public void Ln_Zero_RetornaInfinito()
        {
            // Arrange
            double num = 0;
            double valorEsperado = double.Parse("-∞");
            // Act
            double valorObtido = CalculadoraCientifica.Ln(num);
            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
        #endregion

    }
}
