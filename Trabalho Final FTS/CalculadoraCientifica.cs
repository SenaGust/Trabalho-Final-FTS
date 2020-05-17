using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_FTS
{
    public class CalculadoraCientifica : Calculadora
    {
        public static double Logaritmo(double a) //João
        {
            return Math.Log10(a);
        }

        public static double Sen(double a) //Lorena
        {
            return Math.Round(Math.Sin(a),4);
        }

        public static double Cos(double a) //Nathan
        {
            return Math.Cos(a);
        }

        public static double Tan(double a) //João
        {
            return Math.Tan(a);
        }

        public static double Radiciacao(double a) //Lorena
        {
            return Math.Round(Math.Sqrt(a),4);
        }

        public static double Potenciacao(double a,double b) //Nathan
        {
            return Math.Pow(a,b);
        }

        public static double Porcentagem(double a) //João
        {
            return (a / 100);
        }

        public static double Pi() //Lorena
        {
            return Math.Round(Math.PI,12);
        }

        public static double Ln(double a) //Nathan
        {
            return Math.Log(a);
        }

    }
}
