using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Group1
    {
        public static void EngAlphabet()
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                Console.Write((char)i);
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void EngAlphabetCaps()
        {
            for (int i = 'A'; i <= 'Z'; i++)
            {
                Console.Write((char)i);
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void RusAlphabet()
        {
            for (int i = 'а'; i <= 'я'; i++)
            {
                Console.Write((char)i);
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void Digits()
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write(i);
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void ASCII()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.Write((char)i);
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
