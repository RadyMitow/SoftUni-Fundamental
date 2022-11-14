using System;
using System.Linq;

class CharecterMultiplier
{
    static void Main()
    {
        string input = Console.ReadLine();
        string firstString = input.Split(' ').ToArray()[0];
        string secondString = input.Split(' ').ToArray()[1];

        Console.WriteLine(MultiplyTwoStrings(firstString, secondString));

        int MultiplyTwoStrings(string first, string second)
        {
            int sum = 0;
            int minLength = Math.Min(first.Length, second.Length);
            int maxLength = Math.Max(first.Length, second.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < minLength)
                {
                    sum += first[i] * second[i];
                }
                else if (first.Length == minLength)
                {
                    sum += second[i];
                }
                else
                {
                    sum += first[i];
                }
            }

            return sum;
        }
    }

}
