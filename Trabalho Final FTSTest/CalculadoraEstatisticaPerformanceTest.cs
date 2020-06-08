using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Trabalho_Final_FTS;
using Xunit;

namespace Trabalho_Final_FTSTest
{
    public class CalculadoraEstatisticaPerformanceTest
    {
        static double[] getValores()
        {
            StreamReader streamReader = new StreamReader("../../../performanceTest.txt");
            List<double> teste = new List<double>();

            while (!streamReader.EndOfStream)
                teste.Add(Convert.ToDouble(streamReader.ReadLine()));
            
            streamReader.Close();
            return teste.ToArray();
        }
        [Fact]
        [Trait("CalculadoraEstatistica", "Performance Media")] //Gustavo
        public void Media_ConjuntoNumerosInteiros_RetornaDouble()
        {
            //Arrange
            double[] numeros = getValores();
            double maiorTempoEsperado = 1;
            Stopwatch stopwatch = new Stopwatch();

            //Act
            stopwatch.Start();
            CalculadoraEstatistica.Media(numeros);
            stopwatch.Stop();

            //Assert
            Assert.True(stopwatch.ElapsedMilliseconds < maiorTempoEsperado);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Performance Minimo")] //João
        public void Minimo_ConjuntoNumerosInteiros_RetornaDouble()
        {
            //Arrange
            double[] numeros = getValores();
            double maiorTempoEsperado = 1;
            Stopwatch stopwatch = new Stopwatch();

            //Act
            stopwatch.Start();
            CalculadoraEstatistica.Minimo(numeros);
            stopwatch.Stop();

            //Assert
            Assert.True(stopwatch.ElapsedMilliseconds < maiorTempoEsperado);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Performance Maximo")] //Lorena
        public void Maximo_ConjuntoNumerosInteiros_RetornaDouble()
        {
            //Arrange
            double[] numeros = getValores();
            double maiorTempoEsperado = 1;
            Stopwatch stopwatch = new Stopwatch();

            //Act
            stopwatch.Start();
            CalculadoraEstatistica.Maximo(numeros);
            stopwatch.Stop();

            //Assert
            Assert.True(stopwatch.ElapsedMilliseconds < maiorTempoEsperado);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Performance Mediana")] //Nathan
        public void Mediana_ConjuntoNumerosInteiros_RetornaDouble()
        {
            //Arrange
            double[] numeros = getValores();
            double maiorTempoEsperado = 1;
            Stopwatch stopwatch = new Stopwatch();

            //Act
            stopwatch.Start();
            CalculadoraEstatistica.Mediana(numeros);
            stopwatch.Stop();

            //Assert
            Assert.True(stopwatch.ElapsedMilliseconds < maiorTempoEsperado);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Performance DesvioPadrão")] //Gustavo
        public void DesvioPadrao_ConjuntoNumerosInteiros_RetornaDouble()
        {
            //Arrange
            double[] numeros = getValores();
            double maiorTempoEsperado = 10;
            Stopwatch stopwatch = new Stopwatch();

            //Act
            stopwatch.Start();
            CalculadoraEstatistica.DesvioPadrao(numeros);
            stopwatch.Stop();

            //Assert
            Assert.True(stopwatch.ElapsedMilliseconds < maiorTempoEsperado);
        }

        [Fact]
        [Trait("CalculadoraEstatistica", "Performance Variância")] //João
        public void Variancia_ConjuntoNumerosInteiros_RetornaDouble()
        {
            //Arrange
            double[] numeros = getValores();
            double maiorTempoEsperado = 1;
            Stopwatch stopwatch = new Stopwatch();

            //Act
            stopwatch.Start();
            CalculadoraEstatistica.Variancia(numeros);
            stopwatch.Stop();

            //Assert
            Assert.True(stopwatch.ElapsedMilliseconds < maiorTempoEsperado);
        }
    }
}
