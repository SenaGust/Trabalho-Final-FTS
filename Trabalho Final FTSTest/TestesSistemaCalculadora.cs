using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using Trabalho_Final_FTS;
using NSubstitute.Extensions;
using NSubstitute.ReceivedExtensions;

namespace Trabalho_Final_FTSTest
{
    public class TestesSistemaCalculadora
    {

        #region Calculadora Simples
        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_RealizaSomaDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "2.4444", b = "4.2222";
            double resultadoEsperado = 6.6666;

            // Act            
            calculadoraView.console.ReadLine().Returns("1", a, b, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns("");
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_RealizaSubtracaoDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "2.4444", b = "4.2222";
            double resultadoEsperado = -1.7778;

            // Act            
            calculadoraView.console.ReadLine().Returns("2", a, b, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns("");
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_RealizaMultiplicacaoDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "2.4444", b = "4.2222";
            double resultadoEsperado = 10.3207;

            // Act            
            calculadoraView.console.ReadLine().Returns("3", a, b, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns("");
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_RealizaDivisaoDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "2.4444", b = "4.2222";
            double resultadoEsperado = 0.5789;

            // Act            
            calculadoraView.console.ReadLine().Returns("4", a, b, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns("");
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_EntrarCalculadoraCientifica()
        {
            //Arrange
            CalculadoraView calculadoraView = Substitute.ForPartsOf<CalculadoraView>();
            calculadoraView.console = Substitute.For<IConsole>();
            calculadoraView.console.ReadLine().Returns("5", "14"); //digitar a opção 5 (logaritmo) e depois digitar a opção 14 (fechar)
            calculadoraView.console.ReadKey().Returns("");

            //Act
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.Received().MenuCientifica(); //Chamamos o menu da calculadora cientifica
            calculadoraView.DidNotReceive().MenuSimples(); //Não chamamos o menu da calculadora simples
            calculadoraView.Received().ExecutarCalculadoraCientifica(5); //Chamamos o ExecutarCalculadoraCientifica com a opção 5
            calculadoraView.Received().ExecutarCalculadoraCientifica(14); //Chamamos o ExecutarCalculadoraCientifica com a opção 14
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_ExecutarCalculadoraEstatistica()
        {
            //Arrange
            CalculadoraView calculadoraView = Substitute.ForPartsOf<CalculadoraView>();
            calculadoraView.console = Substitute.For<IConsole>();            
            calculadoraView.console.ReadLine().Returns("6", "11");
            calculadoraView.console.ReadKey().Returns("");

            //Act
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.Received().MenuEstatistica();
            calculadoraView.DidNotReceive().MenuSimples();
            calculadoraView.Received().ExecutarCalculadoraEstatistica(6);
            calculadoraView.Received().ExecutarCalculadoraEstatistica(11);
        }
    
        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_Sair()
        {
            //Arrange
            CalculadoraView calculadoraView = Substitute.ForPartsOf<CalculadoraView>();
            calculadoraView.console = Substitute.For<IConsole>();
            calculadoraView.console.ReadLine().Returns("7");
            calculadoraView.console.ReadKey().Returns("");

            //Act
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.Received().MenuSimples();
        }
        #endregion

        #region Calculadora Cientifica
        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_LogaritmoDouble_RetornaDouble()
        {
            // Arrange
            double num = 4.5;
            double valorEsperado = 0.6532;

            // Act
            double valorObitido = CalculadoraCientifica.Logaritmo(num);

            //Assert
            Assert.Equal(valorEsperado, valorObitido);
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_LnDouble_RetornaDouble()
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
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_SenoDouble_RetornaDouble()
        {
            // Arrange
            double num = 2;
            double valorEsperado = 0.0349;

            // Act
            double valorObitido = CalculadoraCientifica.Sen(num);

            //Assert
            Assert.Equal(valorEsperado, valorObitido);
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_CossenoDouble_RetornaDouble()
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
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_TangenteDouble_RetornaDouble()
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
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_RadiciacaoDouble_RetornaDouble()
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
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PotenciacaoDouble_RetornaDouble()
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
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PorcentagemDouble_RetornaDouble()
        {
            // Arrange
            double num = 25.5;
            double valorEsperado = 0.255;
            // Act
            double valorObtido = CalculadoraCientifica.Porcentagem(num);
            // Assert
            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PiDouble_RetornaDouble()
        {
            // Arrange
            double valorEsperado = 3.14159265359;

            // Act
            double pi = CalculadoraCientifica.Pi();

            //Assert
            Assert.Equal(valorEsperado, pi);
        }
        #endregion



        #region Calculadora Estatistica
        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_MediaVetorDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_MinimoVetorDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_MaximoVetorDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_MedianaVetorDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_DesvioPadraoVetorDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_VarianciaVetorDouble_RetornaDouble()
        {

        }




        #endregion

    }


}
