using System;

namespace ImplementtheCustomListClass
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine(list.Count);

            Console.WriteLine("----------------------");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine(list.RemoveAt(4));

            Console.WriteLine("-----------------------");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine(list.Count);

            Console.WriteLine("-----------------------");

            Console.WriteLine(list.Contains(3));

            Console.WriteLine("-----------------------");
        }
    }
}
