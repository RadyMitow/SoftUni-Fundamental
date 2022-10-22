using System;
using System.Collections.Generic;
using System.Linq;

    class MovingTarget
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] comandInfo = comand.Split();
                string comandName = comandInfo[0];
                int index = int.Parse(comandInfo[1]);
                int value = int.Parse(comandInfo[2]);
                if (comandName == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (comandName == "Add")
                {
                    if (index >=0 && index< targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (comandName == "Strike")
                {
                    if (index - value >=0 && index + value <targets.Count)
                    {
                        targets.RemoveRange(index - value, 2 * value + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }

