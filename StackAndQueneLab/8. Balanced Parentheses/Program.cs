using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Stack<char> stack = new Stack<char>(str);
            Queue<char> queue = new Queue<char>(str);

            bool IsBalanced = false;

            if (stack.Count == queue.Count)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    //stack.Push(str[i]);
                    //queue.Enqueue(str[i]);

                    char ch = stack.Pop();
                    char ch1 = queue.Dequeue();

                    if (ch == '}')
                    {
                        if (ch1 == '{')
                        {
                            IsBalanced = true;
                        }
                        else
                        {
                            IsBalanced = false;
                            break;
                        }
                    }
                    else if(ch == ')')
                    {
                        if (ch1 == '(')
                        {
                            IsBalanced = true;
                        }
                        else
                        {
                            IsBalanced = false;
                            break;
                        }
                    }
                    else if(ch == ']')
                    {
                        if (ch1 == '[')
                        {
                            IsBalanced = true;
                        }
                        else
                        {
                            IsBalanced = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (IsBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
