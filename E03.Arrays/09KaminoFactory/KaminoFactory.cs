using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09KaminoFactory
{
    class KaminoFactory
    {
        static void Main()
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            string commandLine = Console.ReadLine();
            int sum = 0;
            int gratestSequence
            

            do
            {
                int[] dna = commandLine.Split('!').Select(int.Parse).ToArray();
                sum = dna[0];
                int sequece = 1;
                for (int i = 1; i < dna.Length; i++)
                {
                    if (dna[i-1] == dna[i])
                    {
                        sequece++;
                    }
                    else
                    {
                        if (sequece)
                        {

                        }
                    }

                }

            } while (commandLine == "Clone them!");
        }
    }
}
