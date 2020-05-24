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
    public class CalculadoraViewIntegrationTest
    {
            #region Executar Calculadora Simples
        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraSimples")]
        public void ExecutarCalculadora_RealizaSomaDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "2.5", b = "4.3";
            double resultadoEsperado = 6.8;

            // Act            
            calculadoraView.console.ReadLine().Returns("1", a, b, "6"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns("");
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
        }
        #endregion

        #region Executar Calculadora Cientifica
        [Fact]
        [Trait("IntegrationTest", "ExecutarCalculadoraCientifica")]
        public void ExecutarCalculadora_RealizaTanDouble_RetornaDouble()
        {
            //Arrange
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            string a = "45";
            double resultadoEsperado = 1;

            // Act            
            calculadoraView.console.ReadLine().Returns("5", "9", a, "14"); // Simulando o return do CalculadoraView.MenuSimples()
            calculadoraView.console.ReadKey().Returns("");
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.console.Received().WriteLine($"O resultado é {resultadoEsperado}.");
        }
        #endregion
    }
}
