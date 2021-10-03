using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> vlogger = new Dictionary<string, List<string>>();
            Dictionary<string, int[]> follows = new Dictionary<string, int[]>();

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string username = tokens[0];

                if (username.ToLower() == "statistics")
                {
                    break;
                }

                string command = tokens[1];

                if (command.ToLower() == "joined")
                {
                    if (!vlogger.ContainsKey(username))
                    {
                        vlogger[username] = new List<string>();
                        follows[username] = new int[2];
                    }
                }
                else if (command.ToLower() == "followed")
                {
                    string userTofollow = tokens[2];

                    if (vlogger.ContainsKey(username) && vlogger.ContainsKey(userTofollow))
                    {
                        if (!vlogger[userTofollow].Contains(username) && username != userTofollow)
                        {
                            vlogger[userTofollow].Add(username);
                            follows[userTofollow][0]++;
                            follows[username][1]++;
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vlogger.Count} vloggers in its logs.");

            var orderUserAndFollowers = follows
                .OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Value[1])
                .ToDictionary(x => x.Key, x => x.Value);

            int count = 1;
            string userToRemove = string.Empty;

            foreach (var kvp in orderUserAndFollowers)
            {
                userToRemove = kvp.Key;

                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;

                if (vlogger[kvp.Key].Count > 0)
                {
                    foreach (var item in vlogger[kvp.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }

                break;
            }

            orderUserAndFollowers.Remove(userToRemove);

            foreach (var kvp in orderUserAndFollowers)
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;
            }
        }
    }
}
