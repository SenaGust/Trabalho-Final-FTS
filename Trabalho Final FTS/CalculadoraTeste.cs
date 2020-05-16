using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Trabalho_Final_FTS
{
    public class CalculadoraTeste
    {
        [Fact]
        public void FuncaoSomar()
        {
            
        }
        [Fact]
        public void FuncaoSubtrair()
        {

        }
        [Fact]
        public void FuncaoMultiplicar()
        {

        }
        [Fact]
        public void FuncaoDividir_DivisaoNormal()
        {
            Assert.Equal(4, Calculadora.Dividir(8, 2));
        }
        [Fact]
        public void FuncaoDividir_DivisaoPor0()
        {
            Assert.Throws<DivideByZeroException>(() => Calculadora.Dividir(1, 0)); 
        }
    }
}
