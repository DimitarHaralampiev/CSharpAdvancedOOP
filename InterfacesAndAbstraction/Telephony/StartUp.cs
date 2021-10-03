using System;
using System.Linq;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumber = Console.ReadLine()
                .Split()
                .ToArray();

            var webSite = Console.ReadLine()
                .Split()
                .ToArray();

            var smartPhone = new Smartphone();
            var statPhone = new StationaryPhone();

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                string currentNumber = phoneNumber[i];

                try
                {
                    if (currentNumber.Length == 7)
                    {
                        Console.WriteLine(statPhone.Call(currentNumber));
                    }
                    else 
                    {
                        Console.WriteLine(smartPhone.Call(currentNumber));
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }

            for (int i = 0; i < webSite.Length; i++)
            {
                string currentWebSite = webSite[i];

                try
                {
                    Console.WriteLine(smartPhone.WebSite(currentWebSite));
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
               
            }
        }
    }
}
