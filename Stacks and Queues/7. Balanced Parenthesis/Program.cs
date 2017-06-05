using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var parentheses = Console.ReadLine();

            var openedParentheses = new Stack<char>();
            var openingCases = new char[] {'{', '[', '('};
            bool mismach = false;

            for (int i = 0; i < parentheses.Length; i++)
            {
                if (openingCases.Contains(parentheses[i]))
                {
                    openedParentheses.Push(parentheses[i]);
                }
                else
                {
                    if (openedParentheses.Count() == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (parentheses[i])
                    {
                        case '}':
                            if (openedParentheses.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openedParentheses.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openedParentheses.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
