using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Group2
    {
        public string IntToStr(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            return value.ToString();
        }

        public string RealToStr(double value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            return value.ToString();
        }

        public int StrToInt(string value)
        {
            if (value == "")
                throw new ArgumentNullException();
            return Int32.Parse(value);
        }

        public double StrToReal(string value)
        {
            if (value == "")
                throw new ArgumentNullException();
            return Double.Parse(value);
        }


    }
}
