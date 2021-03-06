﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Trabalho_Final_FTS;

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
            //Arrange
            double[] numeros = {15.3, 15.4, 8.4};
            double mediaEsperada = 13.0333;

            //Act
            double media = CalculadoraEstatistica.Media(numeros);

            //Assert
            Assert.Equal(mediaEsperada, media);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Minimo")] //João
        public void Minimo_ConjuntoNumerosInteiros_RetornaDouble()
        {
            //Arrange
            double[] numeros = {  15.75, 20, 0, 1.5, 5.25, -1.5 };
            double valorEsperado = -1.5;

            //Act
            double minimo = CalculadoraEstatistica.Minimo(numeros);

            //Assert
            Assert.Equal(valorEsperado, minimo);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Maximo")] //Lorena
        public void Maximo_ConjuntoNumerosInteiros_RetornaDouble()
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
        [Trait("CalculadoraEstatistica", "Mediana")] //Nathan
        public void Mediana_ConjuntoNumerosInteiros_RetornaDouble()
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
        [Trait("CalculadoraEstatistica", "DesvioPadrão")] //Gustavo
        public void DesvioPadrao_ConjuntoNumerosInteiros_RetornaDouble()
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
        [Trait("CalculadoraEstatistica", "Variância")] //João
        public void Variancia_ConjuntoNumerosInteiros_RetornaDouble()
        {
            //Arrange
            double[] numeros = { 15.75, 20, 0, 1.5, 5.25, -1.5 };
            double valorEsperado = 79.9917;

            //Act
            double variancia = CalculadoraEstatistica.Variancia(numeros);

            //Assert
            Assert.Equal(valorEsperado, variancia);
        }
    }
}
