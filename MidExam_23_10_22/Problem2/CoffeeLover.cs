using System;
using System.Collections.Generic;
using System.Linq;

class CoffeeLover
{
    static void Main(string[] args)
    {
        List<string> coffees = Console.ReadLine().Split(' ').ToList();
        int numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfCommands; i++)
        {
            string[] commandInfo = Console.ReadLine().Split();
            string command = commandInfo[0];
            if (command == "Reverse")
            {
                coffees.Reverse();
            }
            else if (command == "Include")
            {
                string newcoffee = commandInfo[1];
                coffees.Add(newcoffee);
            }
            else if (command == "Remove")
            {
                string position = commandInfo[1];
                int number = int.Parse(commandInfo[2]);

                if (number > coffees.Count)
                {
                    continue;
                }

                if (position == "first")
                {
                    coffees.RemoveRange(0, number);
                }
                else
                {
                    coffees.RemoveRange(coffees.Count - number, number);
                }
            }
            else if (command == "Prefer")
            {
                int firstIndex = int.Parse(commandInfo[1]);
                int secondIndex = int.Parse(commandInfo[2]);

                if (firstIndex < coffees.Count && secondIndex < coffees.Count)
                {
                    string tmp = coffees[firstIndex];
                    coffees[firstIndex] = coffees[secondIndex];
                    coffees[secondIndex] = tmp;
                }


            }
         
        }
        Console.WriteLine("Coffees:");
        Console.WriteLine(string.Join(" ", coffees));
    }
}

