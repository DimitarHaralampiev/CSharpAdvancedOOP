using System;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Decode")
                {
                    break;
                }

                string[] command = line.Split("|");
                string cmd = command[0];

                if (cmd == "Move")
                {
                    int n = int.Parse(command[1]);
                    string txt = text.Substring(0, n);
                    text = text.Remove(0, n);

                    text += txt;
                }
                else if(cmd == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];

                    text = text.Insert(index, value);
                }
                else if (cmd == "ChangeAll")
                {
                    text = text.Replace(command[1], command[2]);
                }
            }
            Console.WriteLine($"The decrypted message is: {text}");
        }
    }
}
