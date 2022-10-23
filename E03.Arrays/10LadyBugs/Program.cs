using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int[] field = new int[size];
        int[] ladyBugsplace = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        for (int i = 0; i < ladyBugsplace.Length; i++)
        {
            if (ladyBugsplace[i]>= 0 && ladyBugsplace[i] < field.Length)
            {
                field[ladyBugsplace[i]] = 1;
            }
        }
        string command = Console.ReadLine();
        while (command != "end")
        {
            int newIndex = 0;
            string[] comandInfo = command.Split();
            int index = int.Parse(comandInfo[0]);
            string direction = comandInfo[1];
            int range = int.Parse(comandInfo[2]);

            if (index >= 0 && index < size)
            {
                if (field[index] == 1)
                {
                    field[index] = 0;
                    if (direction == "left")
                    {
                        range *= -1;
                    }
                        newIndex = index + range;
                        while (newIndex >=0 && newIndex < field.Length && field[newIndex] == 1)
                        {
                            newIndex += range;
                        }
                        if (newIndex >=0 && newIndex < field.Length)
                        {
                            field[newIndex] = 1;
                        }
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" ", field));
    }
}