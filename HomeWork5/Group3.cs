using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Group3
    {
        public int ShortestWord(string str)
        {
            if (str == null)
                throw new ArgumentNullException();
            if (str == "")
                return 0;

            string[] emptyEntries = { " ", ","};

            string[] words = str.Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries);
            string min = words.First();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < min.Length)
                    min = words[i];
            }          
            return min.Length;
        }

        public void LettersToDollars(string[] array, int length)
        {
            if (array.Length == 0)
                throw new EmptyArrayException();
            if (length < 3)
                throw new ArgumentOutOfRangeException();

            string temp = "";
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Length == length)
                {
                    temp = array[i].Remove(array[i].Length - 3);
                    temp += "$$$";
                    array[i] = temp;
                }
            }
        }

        public string AddingSpaces(string str)
        {
            if (str == null)
                throw new ArgumentNullException();
            
            bool punct = false;

            string buf = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsPunctuation(ch) == true)
                {
                    punct = true;
                }
                else
                {
                    if (ch != ' ' && punct)
                    {
                        buf += " ";
                    }
                    punct = false;
                }
                buf += ch;
            }    
            return buf;
        }

        public string LeaveOneOfRepeated(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            return str = new string(str.Distinct().ToArray());
        }

        public int NumberOfWords(string str)
        {
            if (str == null)
                throw new ArgumentNullException();
            if (str == "")
                return 0;

            string[] emptyEntries = { " ", "," };

            string[] words = str.Split(emptyEntries, StringSplitOptions.RemoveEmptyEntries);
            
            return words.Length;
        }

        public string Remove(string str, int pos, int num)
        {
            if (str == null)
                throw new ArgumentNullException();
            if (str == "")
                throw new EmptyArrayException();
            if (pos > str.Length || pos < 0)
                throw new ArgumentOutOfRangeException();

            return str.Remove(pos,num);
        }

        public string Reverse(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string RemoveLastWord(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            string[] emptyEntries = { " ", "," };

            string[] words = str.Split(emptyEntries, StringSplitOptions.None);

            string res = "";
            for (int i = 0; i < words.Length-1; i++)
            {
                res += words[i] + " ";
            }
            
            return res.Trim();
        }
    }
}
