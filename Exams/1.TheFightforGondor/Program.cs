using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.TheFightforGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            var waves = int.Parse(Console.ReadLine());
            var plates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var warriorOrc = new int[waves];
            var four = 0;
            bool isValid = false;

            Queue<int> queuePlates = new Queue<int>(plates);
            Stack<int> stackVoin = null;
            Queue<int> help = new Queue<int>();

            int count = 0;

            for (int i = 0; i < waves; i++)
            {
                warriorOrc = Console.ReadLine().Split().Select(int.Parse).ToArray();
                stackVoin = new Stack<int>(warriorOrc);
               
                if ((plates.Length - i) == 0)
                {
                    //stackVoin.Pop();
                    stackVoin.Push(stackVoin.Pop() - queuePlates.Dequeue());
                    warriorOrc = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    break;
                }

                help.Enqueue(plates[i]);
                count++;

                if (count == 3)
                {
                    four = int.Parse(Console.ReadLine());
                    count = 0;
                    queuePlates.Enqueue(four);
                }

                while (queuePlates.Count > 0 || stackVoin.Count > 0)
                {

                    if (help.Peek() >= stackVoin.Peek())
                    {
                        int result = help.Dequeue() - stackVoin.Pop();
                        help.Enqueue(result);

                        if (result == 0)
                        {
                            help.Dequeue();
                            queuePlates.Dequeue();
                            isValid = true;
                            break;
                        }
                    }
                    else if(stackVoin.Peek() > queuePlates.Peek())
                    {
                        stackVoin.Push(stackVoin.Peek() - queuePlates.Dequeue());

                        if (stackVoin.Peek() == 0)
                        {
                            break;
                        }
                    }
                    else if(stackVoin.Peek() == queuePlates.Peek())
                    {
                        queuePlates.Dequeue();
                        help.Dequeue();
                        stackVoin.Pop();
                    }
                }

            }

            if (stackVoin.Count == 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", queuePlates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", stackVoin)}");
            }
        }
    }
}