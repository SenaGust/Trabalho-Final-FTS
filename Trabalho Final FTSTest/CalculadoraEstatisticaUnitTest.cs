using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Trabalho_Final_FTSTest
{
    //Faz o teste falhar (fazer todo o teste e fazer o push)
    //Faz o suficiente para passar (fazer somente o código passar e faz um push)
    //Refatora (fazer a refotaração e fazer o push)

    public class CalculadoraEstatisticaUnitTest
    {
        [Fact]
        [Trait("CalculadoraEstatistica", "Media")] //Gustavo
        public void Media_ConjuntoNumerosInteiros_RetornaDouble()
        {
            Assert.Equal(0, 1);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Minimo")] //João
        public void Minimo_ConjuntoNumerosInteiros_RetornaDouble()
        {
            Assert.Equal(0, 1);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Maximo")] //Lorena
        public void Maximo_ConjuntoNumerosInteiros_RetornaDouble()
        {
            Assert.Equal(0, 1);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Mediana")] //Nathan
        public void Mediana_ConjuntoNumerosInteiros_RetornaDouble()
        {
            Assert.Equal(0, 1);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "DesvioPadrão")] //Gustavo
        public void DesvioPadrao_ConjuntoNumerosInteiros_RetornaDouble()
        {
            Assert.Equal(0, 1);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Variância")] //João
        public void Variancia_ConjuntoNumerosInteiros_RetornaDouble()
        {
            Assert.Equal(0, 1);
        }
    }
}
