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
            return Math.Round(Math.Log10(a), 4);
        }

        public static double Sen(double a) //Lorena
        {
            double radiano = a * (Math.PI / 180);
            return Math.Round(Math.Sin(radiano), 4);
        }

        public static double Cos(double a) //Nathan
        {
            double radiano = a * (Math.PI / 180);
            return Math.Round(Math.Cos(radiano), 4);
        }

        public static double Tan(double a) //João
        {
            double radiano = a * (Math.PI / 180);
            return Math.Round(Math.Tan(radiano), 4);
        }

        public static double Radiciacao(double a) //Lorena
        {
            return Math.Round(Math.Sqrt(a),4);
        }

        public static double Potenciacao(double a,double b) //Nathan
        {
            return Math.Round(Math.Pow(a,b), 4);
        }

        public static double Porcentagem(double a) //João
        {
            return Math.Round((a / 100), 4);
        }

        public static double Pi() //Lorena
        {
            return Math.Round(Math.PI,12);
        }

        public static double Ln(double a) //Nathan
        {
            return Math.Round(Math.Log(a), 4);
        }

    }
}
