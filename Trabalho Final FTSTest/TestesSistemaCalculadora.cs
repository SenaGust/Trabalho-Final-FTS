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
        public void ExecutarCalculadora_EntrarCalculadoraCientifica_RetornaDouble()
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
        public void ExecutarCalculadora_ExecutarCalculadoraEstatistica_RetornaDouble()
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
        public void ExecutarCalculadora_Sair_RetornaDouble()
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

        #region Calculadora Calculadora
        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_LogaritmoDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_LnDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_SenoDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_CossenoDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_TangenteDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_RadiciacaoDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PotenciacaoDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PorcentagemDouble_RetornaDouble()
        {

        }

        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_PiDouble_RetornaDouble()
        {

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
