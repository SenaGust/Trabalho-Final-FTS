using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_FTS
{
    public class CalculadoraView
    {
        public IConsole console { get; set; }

        public CalculadoraView()
        {
            console = new ConsoleWrapper();
        }

        public void Iniciar()
        {
            int opcaoMenu = 0;
            while (opcaoMenu != 14 && opcaoMenu != 7 && opcaoMenu != 11)
            {
                opcaoMenu = MenuSimples();

                if (opcaoMenu == 5)
                    ExecutarCalculadoraCientifica(MenuCientifica());
                else if (opcaoMenu == 6)
                {
                    ExecutarCalculadoraEstatistica(MenuEstatistica());
                }
                else
                    ExecutarCalculadoraSimples(opcaoMenu);

                console.ReadKey();
                console.Clear();
            }
        }

        public int MenuEstatistica()
        {
            console.WriteLine(".:Calculadora Estatística:.");

            console.WriteLine("\t 1. Somar");
            console.WriteLine("\t 2. Subtrair");
            console.WriteLine("\t 3. Multiplicar");
            console.WriteLine("\t 4. Dividir");
            console.WriteLine("\t 5. Media");
            console.WriteLine("\t 6. Mínimo");
            console.WriteLine("\t 7. Máximo");
            console.WriteLine("\t 8. Mediana");
            console.WriteLine("\t 9. Desvio Padrão");
            console.WriteLine("\t 10. Variância");
            console.WriteLine("\t 11. Sair");

            console.Write("Escolha uma das opções acima: ");

            return Convert.ToInt32(console.ReadLine());
        }

        public int MenuCientifica()
        {
            console.WriteLine(".:Calculadora Cientifica:.");

            console.WriteLine("\t 1. Somar");
            console.WriteLine("\t 2. Subtrair");
            console.WriteLine("\t 3. Multiplicar");
            console.WriteLine("\t 4. Dividir");
            console.WriteLine("\t 5. Logaritmo");
            console.WriteLine("\t 6. Ln");
            console.WriteLine("\t 7. Seno");
            console.WriteLine("\t 8. Cosseno");
            console.WriteLine("\t 9. Tangente");
            console.WriteLine("\t10. Radiciação");
            console.WriteLine("\t11. Ponteciação");
            console.WriteLine("\t12. Porcentagem");
            console.WriteLine("\t13. Pi");
            console.WriteLine("\t14. Sair");

            console.Write("Escolha uma das opções acima: ");

            return Convert.ToInt32(console.ReadLine());
        }

        public int MenuSimples()
        {
            console.WriteLine("\t\t.:Calculadora:.");

            console.WriteLine("\t1. Somar");
            console.WriteLine("\t2. Subtrair");
            console.WriteLine("\t3. Multiplicar");
            console.WriteLine("\t4. Dividir");
            console.WriteLine("\t5. Calculadora Científica");
            console.WriteLine("\t6. Calculadora Estatística");
            console.WriteLine("\t7. Sair");

            console.Write("Escolha uma das opções acima: ");

            return Convert.ToInt32(console.ReadLine());
        }

        public void ExecutarCalculadoraSimples(int opcao)
        {
            double a, b;
            Func<double, double, double> funcao;

            switch (opcao)
            {
                case 1:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao = (x, y) => Calculadora.Somar(x, y);

                    console.WriteLine("O resultado é " + funcao(a, b) + ".");
                    break;

                case 2:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao = (x, y) => Calculadora.Subtrair(x, y);

                    console.WriteLine("O resultado é " + funcao(a, b) + ".");
                    break;

                case 3:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao = (x, y) => Calculadora.Multiplicar(x, y);

                    console.WriteLine("O resultado é " + funcao(a, b) + ".");
                    break;

                case 4:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao = (x, y) => Calculadora.Dividir(x, y);

                    console.WriteLine("O resultado é " + funcao(a, b) + ".");
                    break;

                case 5:
                    console.WriteLine("Abrindo calculadora cientifica...");
                    break;
                case 6:
                    console.WriteLine("Abrindo calculadora estatistica...");
                    break;
                case 7:
                    console.WriteLine("Digite qualquer tecla para encerrar o programa...");
                    break;
                default:
                    console.WriteLine("Escolha outra opção.");
                    break;
            }
        }

        public void ExecutarCalculadoraCientifica(int opcao)
        {
            double a, b;
            Func<double, double> funcao1;
            Func<double, double, double> funcao2;


            switch (opcao)
            {
                case 1:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Somar(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 2:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Subtrair(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 3:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Multiplicar(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 4:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Dividir(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 5:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Logaritmo(x);

                    console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 6:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Ln(x);

                    console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 7:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Sen(x);

                    console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 8:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Cos(x);

                    console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 9:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Tan(x);

                    console.WriteLine("O resultado é " + funcao1(a) + "."); ;
                    break;
                case 10:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Radiciacao(x);

                    console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 11:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Potenciacao(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;
                case 12:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Porcentagem(x);

                    console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 13:
                    Func<double> funcao = () => CalculadoraCientifica.Pi();

                    console.WriteLine("O resultado é " + funcao() + ".");
                    break;
                case 14:

                    console.WriteLine("Digite qualquer tecla para encerrar o programa...");
                    break;
                default:
                    console.WriteLine("Escolha outra opção.");
                    break;
            }
        }

        public void ExecutarCalculadoraEstatistica(int opcao)
        {
            double a, b;
            double[] c;
            Func<double, double> funcao1;
            Func<double, double, double> funcao2;
            Func<double[], double> funcao3;


            switch (opcao)
            {
                case 1:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraEstatistica.Somar(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 2:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraEstatistica.Subtrair(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 3:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraEstatistica.Multiplicar(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 4:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraEstatistica.Dividir(x, y);

                    console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 5:
                    c = ReceberValores();

                    funcao3 = (x) => CalculadoraEstatistica.Media(x);

                    console.WriteLine("O resultado é " + funcao3(c) + ".");
                    break;
                case 6:
                    c = ReceberValores();

                    funcao3 = (x) => CalculadoraEstatistica.Minimo(x);

                    console.WriteLine("O resultado é " + funcao3(c) + ".");
                    break;
                case 7:
                    c = ReceberValores();

                    funcao3 = (x) => CalculadoraEstatistica.Maximo(x);

                    console.WriteLine("O resultado é " + funcao3(c) + ".");
                    break;
                case 8:
                    c = ReceberValores();

                    funcao3 = (x) => CalculadoraEstatistica.Mediana(x);

                    console.WriteLine("O resultado é " + funcao3(c) + ".");
                    break;
                case 9:
                    c = ReceberValores();

                    funcao3 = (x) => CalculadoraEstatistica.DesvioPadrao(x);

                    console.WriteLine("O resultado é " + funcao3(c) + "."); ;
                    break;
                case 10:
                    c = ReceberValores();

                    funcao3 = (x) => CalculadoraEstatistica.Variancia(x);

                    console.WriteLine("O resultado é " + funcao3(c) + ".");
                    break;
                case 11:

                    console.WriteLine("Digite qualquer tecla para encerrar o programa...");
                    break;
                default:
                    console.WriteLine("Escolha outra opção.");
                    break;
            }
        }

        public double ReceberValor()
        {
            console.Write("Insira um valor: ");
            return Convert.ToDouble(console.ReadLine());
        }

        public double[] ReceberValores()
        {
            console.Write("Insira os valores separados por um espaço: ");
            string valores = console.ReadLine();
            string[] aux = valores.Split(' ');

            double[] vetorValores = new double[valores.Length];

            for (int i = 0; i < aux.Length; i++)
            {
                vetorValores[i] = double.Parse(aux[i]);
            }

            return vetorValores;
        }
    }
}
