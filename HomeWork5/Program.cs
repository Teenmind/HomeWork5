using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);

            Group1.EngAlphabet();
            Group1.EngAlphabetCaps();
            Group1.RusAlphabet();
            Group1.Digits();
            Group1.ASCII();
        }

    }
}
