﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_FTS
{
    public class Calculadora
    {
        public static double Somar(double a, double b)
        {
            return Math.Round(a + b, 4);
        }
        public static double Subtrair(double a, double b)
        {
            return Math.Round(a - b, 4);
        }
        public static double Multiplicar(double a, double b)
        {
            return Math.Round(a * b, 4);
        }
        public static double Dividir(double a, double b)
        {
            return Math.Round(a / b, 4);
        }
    }
}
