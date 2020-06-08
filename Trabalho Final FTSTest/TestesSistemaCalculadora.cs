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
        [Theory]
        [InlineData("2.4444", "4.2222", 6.6666)]
        [InlineData("-2.4444", "-4.2222", -6.6666)]
        [InlineData("-2.4444", "4.2222", 1.7778)]
        [InlineData("2.4444", "-4.2222", -1.7778)]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_RealizaSomaDouble_RetornaDouble(string a, string b, double resultadoEsperado)
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();

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

            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "4,5";
            double resultadoEsperado = 0.6532;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "5", a, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_logaritmo, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_LnDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "25";
            double resultadoEsperado = 3.2189;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "6", a, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_Ln, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");

          
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_SenoDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "2";
            double resultadoEsperado = 0.0349;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "7", a, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_seno, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
          
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_CossenoDouble_RetornaDouble()
        {
            
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "2";
            double resultadoEsperado = 0.9994;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "8", a, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_cos, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
            
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_TangenteDouble_RetornaDouble()
        {

            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "45";
            double resultadoEsperado = 1;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "9", a,"7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_tangente, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");

           
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_RadiciacaoDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "72";
            double resultadoEsperado = 8.4853;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "10", a, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_seno, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
            
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PotenciacaoDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "100";
            string b = "0";
            double resultadoEsperado = 1;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "11", a,b, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_seno, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
            
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PorcentagemDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "25,5";
            double resultadoEsperado = 0.255;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "12", a, "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_seno, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
           
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PiDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            double resultadoEsperado = 3.14159265359;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "13", "7"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns(""); //Entrar na calculadora_cientifica, entrar_seno, número a calcular, sair
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
           
        }
        #endregion



        #region Calculadora Estatistica
        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraEstatistica")]
        public void ExecutarCalculadora_MediaVetorDouble_RetornaDouble()
        {
            //Arrange
            double[] numeros = { 15.3, 15.4, 8.4 };
            double mediaEsperada = 13.0333;

            //Act
            double media = CalculadoraEstatistica.Media(numeros);

            //Assert
            Assert.Equal(mediaEsperada, media);
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraEstatistica")]
        public void ExecutarCalculadora_MinimoVetorDouble_RetornaDouble()
        {
            //Arrange
            double[] numeros = { 15.75, 20, 0, 1.5, 5.25, -1.5 };
            double valorEsperado = -1.5;

            //Act
            double minimo = CalculadoraEstatistica.Minimo(numeros);

            //Assert
            Assert.Equal(valorEsperado, minimo);
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraEstatistica")]
        public void ExecutarCalculadora_MaximoVetorDouble_RetornaDouble()
        {
            //Arrange
            double[] numeros = { 12, 8, 25, 5 };
            double valorEsperado = 25;

            //Act
            double maximo = CalculadoraEstatistica.Maximo(numeros);

            //Assert
            Assert.Equal(valorEsperado, maximo);
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraEstatistica")]
        public void ExecutarCalculadora_MedianaVetorDouble_RetornaDouble()
        {
            //Arrange
            double[] valores = { 20.0, 10.0, 50.0, 7.0, 8.0 };
            double valorEsperado = 10.0;

            //Act
            double mediana = CalculadoraEstatistica.Mediana(valores);

            //Assert
            Assert.Equal(valorEsperado, mediana);
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraEstatistica")]
        public void ExecutarCalculadora_DesvioPadraoVetorDouble_RetornaDouble()
        {
            //Arrange
            double[] numeros = { 15.3, 15.4, 8.4 };
            double desvioPadraoEsperado = 4.0129;

            //Act
            double desvioPadrao = CalculadoraEstatistica.DesvioPadrao(numeros);

            //Assert
            Assert.Equal(desvioPadraoEsperado, desvioPadrao);
        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraEstatistica")]
        public void ExecutarCalculadora_VarianciaVetorDouble_RetornaDouble()
        {
            //Arrange
            double[] numeros = { 15.75, 20, 0, 1.5, 5.25, -1.5 };
            double valorEsperado = 79.9917;

            //Act
            double variancia = CalculadoraEstatistica.Variancia(numeros);

            //Assert
            Assert.Equal(valorEsperado, variancia);
        }

        #endregion
    }
}
