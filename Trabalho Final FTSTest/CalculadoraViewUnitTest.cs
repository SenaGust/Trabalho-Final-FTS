using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using NSubstitute;
using Trabalho_Final_FTS;
using NSubstitute.Extensions;
using NSubstitute.ReceivedExtensions;

namespace Trabalho_Final_FTSTest
{
   public class CalculadoraViewUnitTest
    {
        #region Iniciar
        [Fact]
        [Trait("CalculadoraView", "Iniciar")]
        public void Iniciar_IniciarCalculadoraSimples_ChamarExecutarCalculadoraSimples()
        {
            //Arrange
            CalculadoraView calculadoraView = Substitute.ForPartsOf<CalculadoraView>();
            calculadoraView.console = Substitute.For<IConsole>();

            calculadoraView.console.ReadLine().Returns("2", "6"); //digitar a opção 2 (subtrair) e depois digitar a opção 6 (fechar)
            calculadoraView.console.ReadKey().Returns("");

            //Act
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.DidNotReceive().MenuCientifica(); //Não chamamos o menu da calculadora cientifica
            calculadoraView.Received().MenuSimples(); //Chamamos o menu da calculadora simples

            calculadoraView.Received().ExecutarCalculadoraSimples(2); //Chamamos o ExecutarCalculadoraCientifica com a opção 2
            calculadoraView.Received().ExecutarCalculadoraSimples(6); //Chamamos o ExecutarCalculadoraCientifica com a opção 6
        }
        [Fact]
        [Trait("CalculadoraView", "Iniciar")]
        public void Iniciar_IniciarCalculadoraCientifica_ChamarExecutarCalculadoraCientifica()
        {
            //Arrange
            CalculadoraView calculadoraView = Substitute.ForPartsOf<CalculadoraView>();
            calculadoraView.console = Substitute.For<IConsole>();
            calculadoraView.useCientifica = true;

            calculadoraView.console.ReadLine().Returns("5","14"); //digitar a opção 5 (logaritmo) e depois digitar a opção 14 (fechar)
            calculadoraView.console.ReadKey().Returns("");

            //Act
            calculadoraView.Iniciar();

            //Assert
            calculadoraView.Received().MenuCientifica(); //Chamamos o menu da calculadora cientifica
            calculadoraView.DidNotReceive().MenuSimples(); //Não chamamos o menu da calculadora simples
            calculadoraView.Received().ExecutarCalculadoraCientifica(5); //Chamamos o ExecutarCalculadoraCientifica com a opção 5
            calculadoraView.Received().ExecutarCalculadoraCientifica(14); //Chamamos o ExecutarCalculadoraCientifica com a opção 14
        }
        #endregion

        #region Menu Calculadora Simples
        [Fact]
        [Trait("CalculadoraView", "MenuSimples")]
        public void MenuSimples_ExibirMenuSimples_Retornar2()
        {
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            int retornoEsperado = 2;
            calculadoraView.console.ReadLine().Returns("2");

            int retorno = calculadoraView.MenuSimples();

            calculadoraView.console.Received().WriteLine("\t\t.:Calculadora:.");
            calculadoraView.console.Received().WriteLine("\t1. Somar");
            calculadoraView.console.Received().WriteLine("\t2. Subtrair");
            calculadoraView.console.Received().WriteLine("\t3. Multiplicar");
            calculadoraView.console.Received().WriteLine("\t4. Dividir");
            calculadoraView.console.Received().WriteLine("\t5. Calculadora Científica");
            calculadoraView.console.Received().WriteLine("\t6. Sair");
            Assert.Equal(retornoEsperado, retorno);
        }
        #endregion

        #region Menu Calculadora Cientifica
        [Fact]
        [Trait("CalculadoraView", "MenuCientifica")]
        public void MenuCientifica_ExibirMenuCientifica_Retornar1()
        {
            CalculadoraView calculadoraView = new CalculadoraView();
            calculadoraView.console = Substitute.For<IConsole>();
            calculadoraView.console.ReadLine().Returns("1");
            int resultadoEsperado = 1;

            int resultado = calculadoraView.MenuCientifica();

            //Grantindo que o resultado esperado foi retornado pelo console.ReadLine();
            Assert.Equal(resultadoEsperado, resultado);

            //Garantindo que chamei todo o menu usando console.WriteLine()
            calculadoraView.console.Received().WriteLine(".:Calculadora Cientifica:.");
            calculadoraView.console.Received().WriteLine("\t 1. Somar");
            calculadoraView.console.Received().WriteLine("\t 2. Subtrair");
            calculadoraView.console.Received().WriteLine("\t 3. Multiplicar");
            calculadoraView.console.Received().WriteLine("\t 4. Dividir");
            calculadoraView.console.Received().WriteLine("\t 5. Logaritmo");
            calculadoraView.console.Received().WriteLine("\t 6. Ln");
            calculadoraView.console.Received().WriteLine("\t 7. Seno");
            calculadoraView.console.Received().WriteLine("\t 8. Cosseno");
            calculadoraView.console.Received().WriteLine("\t 9. Tangente");
            calculadoraView.console.Received().WriteLine("\t10. Radiciação");
            calculadoraView.console.Received().WriteLine("\t11. Ponteciação");
            calculadoraView.console.Received().WriteLine("\t12. Porcentagem");
            calculadoraView.console.Received().WriteLine("\t13. Pi");
            calculadoraView.console.Received().WriteLine("\t14. Sair");
            calculadoraView.console.Received().Write("Escolha uma das opções acima: ");
        }
        #endregion

        #region Executar Calculadora Simples

        #endregion

        #region Executar Calculadora Cientifica

        #endregion

        #region Receber Valores

        [Fact]
        [Trait("CalculadoraView", "ReceberValores")]
        public void ReceberValores_UsuarioDigita3_Retorna3()
        {
            CalculadoraView calculadora = new CalculadoraView();
            calculadora.console = Substitute.For<IConsole>(); ////cria objeto mock
            calculadora.console.ReadLine().Returns("3");

            double valorEsperado = 3;

            double resultado = calculadora.ReceberValor();

            Assert.Equal(valorEsperado, resultado);
        }
        #endregion
    }
}
