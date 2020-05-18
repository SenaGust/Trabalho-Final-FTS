using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_FTS
{
    public interface IConsole
    {
        string ReadKey();
        string ReadLine();
        void WriteLine(string frase);
        void Write(string frase);
        void Clear();
    }   
}
