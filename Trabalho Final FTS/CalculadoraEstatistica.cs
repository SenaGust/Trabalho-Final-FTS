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
            return Math.Round(conjuntoNumeros.Sum() / conjuntoNumeros.Length, 4);
        }

        public static double Minimo(double[] conjuntoNumeros)
        {
            return conjuntoNumeros.Min();
        }

        public static double Maximo(double[] conjuntoNumeros)
        {
            return conjuntoNumeros.Max();
        }

        public static double Mediana(double[] conjuntoNumeros)
        {
            if (conjuntoNumeros.Length > 1)
            {
                int metade = conjuntoNumeros.Length / 2;
                Array.Sort(conjuntoNumeros);

                if (conjuntoNumeros.Length % 2 != 0)
                    return conjuntoNumeros[metade];
                else
                    return (conjuntoNumeros[metade - 1] +
                        conjuntoNumeros[metade + 1]) / 2;
            }
            else
                return conjuntoNumeros[0];
        }

        public static double DesvioPadrao(double[] conjuntoNumeros)
        {
            double somaTotalMedias = 0;

            for (int i = 0; i < conjuntoNumeros.Length; i++)
                somaTotalMedias += Math.Pow(conjuntoNumeros[i] - (conjuntoNumeros.Sum() / conjuntoNumeros.Length), 2);

            return Math.Round(Math.Sqrt(somaTotalMedias / conjuntoNumeros.Length), 4);
        }

        public static double Variancia(double[] conjuntoNumeros)
        {
            double variancia = 0, media = Media(conjuntoNumeros);

            for(int i = 0; i < conjuntoNumeros.Length; i++)
                variancia += CalculadoraCientifica.Potenciacao(conjuntoNumeros[i] - media, 2);

            return Math.Round(variancia /= (conjuntoNumeros.Length - 1), 4);
        }
    }
}
