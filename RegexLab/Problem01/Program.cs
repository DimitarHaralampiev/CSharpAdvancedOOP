using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] cmd = line.Split(" ");
                string command = cmd[0];

                if (command == "add")
                {
                    int int1 = int.Parse(cmd[3]);
                    int int2 = int.Parse(cmd[4]);

                    if (cmd[2] == "start")
                    {
                        int int3 = int.Parse(cmd[5]);

                        list.Insert(0, int1);
                        list.Insert(1, int2);
                        list.Insert(2, int3);
                    }
                    else
                    {
                        list.Add(int1);
                        list.Add(int2);
                    }
                }
                else if(command == "remove")
                {
                    

                    if (cmd[1] == "lower")
                    {
                        int value = int.Parse(cmd[3]);
                        for (int i = 0; i < list.Count; i++)
                        {
                            int curr = list[i];
                            if (curr < value)
                            {
                                list.Remove(curr);
                                i--;
                            }
                        }
                    }
                    else if(cmd[1] == "greater")
                    {
                        //int value = int.Parse(cmd[3]);
                        int value = int.Parse(cmd[3]);
                        for (int i = 0; i < list.Count; i++)
                        {
                            int curr = list[i];
                            if (curr > value)
                            {
                                list.Remove(curr);
                                i--;
                            }
                        }
                    }
                    else if(cmd[2] == "index")
                    {
                        int value = int.Parse(cmd[3]);
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (i == value)
                            {
                                list.RemoveAt(i);
                            }
                        }
                    }
                    else if(cmd[1] == "count")
                    {
                        int index = int.Parse(cmd[2]);
                        list.RemoveRange(list.Count - index, index);
                    }
                }
                else if(command == "replace")
                {
                    int value = int.Parse(cmd[1]);
                    int repl = int.Parse(cmd[2]);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == value)
                        {
                            list.Remove(list[i]);
                            list.Insert(i, repl);
                            break;
                        }
                    }
                }
                else if(command == "find")
                {
                    if (cmd[1] == "even")
                    {
                        for (int i = 1; i < list.Count; i++)
                        {
                            if (list[i] % 2 == 0)
                            {
                                Console.Write(list[i] + " ");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 != 0)
                            {
                                Console.Write(list[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine($"{string.Join(", ", list)}");
        }
    }
}
