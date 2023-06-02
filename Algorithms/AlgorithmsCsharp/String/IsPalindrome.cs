using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCsharp
{
    partial class main
    {
        static bool IsPalindrome(string x)
        {
            string xString = "";
            string yString = "";

            xString = x;

            foreach (char e in xString)
            {
                yString = e + yString;
            }

            if (xString == yString)
            {
                return true;
            }

            return false;
        }
    }
}
