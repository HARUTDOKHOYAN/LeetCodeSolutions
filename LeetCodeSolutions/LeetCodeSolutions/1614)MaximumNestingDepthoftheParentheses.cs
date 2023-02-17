using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class _1614_MaximumNestingDepthoftheParentheses : ILeetCodeExecute
    {
        public int MaxDepth(string s)
        {
            int  MaxDepth = 0;
            int currentDepth = 0;

            foreach (var simbol in s)
            {
                if (simbol == '(')
                {
                    currentDepth++;

                    MaxDepth = currentDepth > MaxDepth ? currentDepth : MaxDepth;
                }
                else if (simbol == ')') 
                    currentDepth--;
            }

            return MaxDepth;
        }
        public void Execute()
        {
            Console.WriteLine(MaxDepth("(1)+((2))+(((3)))"));
        }
    }
}
