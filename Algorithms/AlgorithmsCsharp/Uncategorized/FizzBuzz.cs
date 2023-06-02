using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCsharp
{
    partial class main
    {
        static string[] FizzBuzz(int n)
        {
            string[] answerArray = new string[n];

            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    answerArray[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    answerArray[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    answerArray[i - 1] = "Buzz";
                }
                else
                {
                    answerArray[i - 1] = "" + i + "";
                }
            }

            return answerArray;
        }
    }
}
