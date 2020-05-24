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
        public bool useCientifica { get; set; }
        public IConsole console { get; set; }

        public CalculadoraView()
        {
            console = new ConsoleWrapper();
            useCientifica = false;
        }

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

                console.ReadKey();
                console.Clear();
            }
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
            console.WriteLine("\t6. Sair");
            
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
                    useCientifica = true;

                    console.WriteLine("Abrindo calculadora cientifica...");
                    break;
                case 6:
                    console.WriteLine("Encerrando o programa...");
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

                    funcao2 = (x, y) => CalculadoraCientifica.Multiplicar(x,y);

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

                    console.WriteLine("Encerrando o programa...");
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
    }
}
