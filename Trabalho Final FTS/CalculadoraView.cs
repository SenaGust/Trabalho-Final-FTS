using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_FTS
{
    class CalculadoraView
    {
        private static bool useCientifica = false;
        public void Iniciar() 
        {   
            int opcaoMenu = 0;
            while (opcaoMenu != (useCientifica ? 14 : 6))
            {
                opcaoMenu = useCientifica ? MenuCientifica() : MenuSimples();

                if (useCientifica)
                    ExecutarCalculadoraCientifica(opcaoMenu);
                else
                    ExecutarCalculadoraSimples(opcaoMenu);

                Console.ReadKey();
                Console.Clear();
            }
        }

        int MenuCientifica()
        {
            Console.WriteLine(".:Calculadora Cientifica:.");
            
            Console.WriteLine("\t 1. Somar");
            Console.WriteLine("\t 2. Subtrair");
            Console.WriteLine("\t 3. Multiplicar");
            Console.WriteLine("\t 4. Dividir");
            Console.WriteLine("\t 5. Logaritmo");
            Console.WriteLine("\t 6. Ln");
            Console.WriteLine("\t 7. Seno");
            Console.WriteLine("\t 8. Cosseno");
            Console.WriteLine("\t 9. Tangente");
            Console.WriteLine("\t10. Radiciação");
            Console.WriteLine("\t11. Ponteciação");
            Console.WriteLine("\t12. Porcentagem");
            Console.WriteLine("\t13. Pi");
            Console.WriteLine("\t14. Sair");
            
            Console.Write("Escolha uma das opções acima: ");

            return Convert.ToInt32(Console.ReadLine());
        }
        int MenuSimples()
        {
            Console.WriteLine("\t\t.:Calculadora:.");

            Console.WriteLine("\t1. Somar");
            Console.WriteLine("\t2. Subtrair");
            Console.WriteLine("\t3. Multiplicar");
            Console.WriteLine("\t4. Dividir");
            Console.WriteLine("\t5. Calculadora Científica");
            Console.WriteLine("\t6. Sair");
            
            Console.Write("Escolha uma das opções acima: ");
            
            return Convert.ToInt32(Console.ReadLine());
        }

        void ExecutarCalculadoraSimples(int opcao)
        {
            double a, b;
            Func<double, double, double> funcao;

            switch (opcao)
            {
                case 1:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao = (x, y) => Calculadora.Somar(x, y);

                    Console.WriteLine("O resultado é " + funcao(a, b) + ".");
                    break;

                case 2:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao = (x, y) => Calculadora.Subtrair(x, y);

                    Console.WriteLine("O resultado é " + funcao(a, b) + ".");
                    break;

                case 3:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao = (x, y) => Calculadora.Multiplicar(x, y);

                    Console.WriteLine("O resultado é " + funcao(a, b) + ".");
                    break;

                case 4:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao = (x, y) => Calculadora.Dividir(x, y);

                    Console.WriteLine("O resultado é " + funcao(a, b) + ".");
                    break;

                case 5:
                    useCientifica = true;

                    Console.WriteLine("Abrindo calculadora cientifica...");
                    break;
                case 6:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Escolha outra opção.");
                    break;
            }
        }
        void ExecutarCalculadoraCientifica(int opcao)
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

                    Console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 2:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Subtrair(x, y);

                    Console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 3:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Multiplicar(x,y);

                    Console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 4:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Dividir(x, y);

                    Console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;

                case 5:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Logaritmo(x);

                    Console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 6:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Ln(x);

                    Console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 7:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Sen(x);

                    Console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 8:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Cos(x);

                    Console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 9:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Tan(x);

                    Console.WriteLine("O resultado é " + funcao1(a) + "."); ;
                    break;
                case 10:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Radiciacao(x);

                    Console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 11:
                    a = ReceberValor();
                    b = ReceberValor();

                    funcao2 = (x, y) => CalculadoraCientifica.Potenciacao(x, y);

                    Console.WriteLine("O resultado é " + funcao2(a, b) + ".");
                    break;
                case 12:
                    a = ReceberValor();

                    funcao1 = (x) => CalculadoraCientifica.Porcentagem(x);

                    Console.WriteLine("O resultado é " + funcao1(a) + ".");
                    break;
                case 13:
                    Func<double> funcao = () => CalculadoraCientifica.Pi();

                    Console.WriteLine("O resultado é " + funcao() + ".");
                    break;
                case 14:

                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Escolha outra opção.");
                    break;
            }
        }

        double ReceberValor()
        {
            Console.Write("Insira um valor: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
