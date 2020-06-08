using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_FTS
{
    public class CalculadoraEstatistica : Calculadora
    {
        public static double Media(double[] conjuntoNumeros)
        {
            double somaTotal = 0;

            for (int i = 0; i < conjuntoNumeros.Length; i++)
            {
                somaTotal = conjuntoNumeros[i];
            }
            return (somaTotal/conjuntoNumeros.Length);
        }

        public static double Minimo(double[] conjuntoNumeros)
        {
            double menor = double.MaxValue;

            for (int i = 0; i < conjuntoNumeros.Length; i++)
            {
                if (conjuntoNumeros[i] < menor)
                {
                    menor = conjuntoNumeros[i];
                }
            }

            return menor;
        }

        public static double Maximo(double[] conjuntoNumeros)
        {
            double maximo = double.MinValue;
            for (int i = 0; i < conjuntoNumeros.Length; i++)
            {
                if(conjuntoNumeros[i] > maximo)
                {
                    maximo = conjuntoNumeros[i];
                }
            }
            return maximo;
        }

        public static double Mediana(double[] conjuntoNumeros)
        {
            if(conjuntoNumeros.Length > 1)
            {
                Array.Sort(conjuntoNumeros);
                if (conjuntoNumeros.Length % 2 != 0)
                {
                    return conjuntoNumeros[conjuntoNumeros.Length / 2];
                }
                else
                {
                    return (conjuntoNumeros[(conjuntoNumeros.Length / 2) - 1] +
                        conjuntoNumeros[(conjuntoNumeros.Length / 2) + 1]) / 2;
                }
            }
            else
            {
                return conjuntoNumeros[0];
            
            }
        }

        public static double DesvioPadrao(double[] conjuntoNumeros)
        {
            double somaTotalMedias = 0;
            double media = 0;
            media = conjuntoNumeros.Sum() / conjuntoNumeros.Length;

            for (int i = 0; i < conjuntoNumeros.Length; i++)
            {
                double aux = conjuntoNumeros[i] - media;
                somaTotalMedias += Math.Pow(aux, 2);
            }

            double desvioPadrao = Math.Sqrt(somaTotalMedias / conjuntoNumeros.Length);

            return desvioPadrao;
        }

        public static double Variancia(double[] conjuntoNumeros)
        {
            double variancia = 0;
            double media = 0;
            media = conjuntoNumeros.Sum() / conjuntoNumeros.Length;

            for (int i = 0; i < conjuntoNumeros.Length; i++)
            {
                variancia += CalculadoraCientifica.Radiciacao(conjuntoNumeros[i] - media);
            }
            return variancia /= conjuntoNumeros.Length - 1;
        }
    }
}
