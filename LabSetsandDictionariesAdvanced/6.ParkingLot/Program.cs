using System;
using System.Collections.Generic;

namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> tableNumber = new HashSet<string>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = command[0];

                if (cmd == "END")
                {
                    break;
                }

                string number = command[1];

                if (cmd == "IN")
                {
                    tableNumber.Add(number);
                }
                else if (cmd == "OUT")
                {
                    tableNumber.Remove(number);
                }
            }

            if (tableNumber.Count > 0)
            {
                foreach (var item in tableNumber)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
