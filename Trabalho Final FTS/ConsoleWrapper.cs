using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_FTS
{
    public class ConsoleWrapper : IConsole
    {
        public string ReadKey()
        {
            return Convert.ToString(Console.ReadKey().Key);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string frase)
        {
            Console.Write(frase);
        }

        public void WriteLine(string frase)
        {
            Console.WriteLine(frase);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
