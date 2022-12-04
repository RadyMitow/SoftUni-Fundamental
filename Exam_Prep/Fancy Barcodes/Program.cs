using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-z][A-Za-z0-9]{4,}[A-z]@#+";
            Regex barCodeRegex = new Regex(pattern);
            Regex productGroupRegex = new Regex(@"\d+");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                var match = barCodeRegex.Match(barcode);
                if (match.Success)
                {
                    MatchCollection productGroupMatch = productGroupRegex.Matches(match.Value);
                    if (productGroupMatch.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", productGroupMatch)}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}