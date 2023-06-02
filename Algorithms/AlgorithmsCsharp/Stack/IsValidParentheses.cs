using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCsharp
{
    partial class main
    {
        static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            if (s.Length % 2 != 0)
            {
                return false;
            }

            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '[')
                {
                    stack.Push(']');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (stack.Count == 0 || c != stack.Pop())
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
