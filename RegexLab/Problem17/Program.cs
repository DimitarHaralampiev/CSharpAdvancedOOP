using System;
using System.Text.RegularExpressions;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //string text = string.Empty;

            Regex regex = new Regex(@"^@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$");
            Regex digitRegex = new Regex(@"\d");

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                Match match = regex.Match(text);

                if (match.Success)
                {
                    var input = match.Groups["barcode"].Value;
                    var digMathes = digitRegex.Matches(input);
                    string product = string.Empty;

                    foreach (Match item in digMathes)
                    {
                        if (item.Success)
                        {
                            product += item.Value;
                        }
                    }

                    if (product.Length == 0)
                    {
                        product = "00";
                    }

                    Console.WriteLine($"Product group: {product}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
