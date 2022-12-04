using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 20;
            int c = a > b ? a : b;
            Console.WriteLine(c);
            bool isTrue = 100f == 100d;
            Console.WriteLine(isTrue);
            Console.ReadLine();

        }
    }
}
