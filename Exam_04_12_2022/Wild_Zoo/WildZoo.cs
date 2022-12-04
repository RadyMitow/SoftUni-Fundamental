using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class WildZoo
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> animals = new Dictionary<string, Dictionary<string, int>>();
        string command = Console.ReadLine();

        while (command != "EndDay")
        {
            string[] commandInfo = command.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            string commandName = commandInfo[0];
            string[] commandproperties = commandInfo[1].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            if (commandName == "Add")
            {
                string name = commandproperties[0];
                int neededFood = int.Parse(commandproperties[1]);
                string area = commandproperties[2];

                if (!animals.ContainsKey(name))
                {
                    animals.Add(name, new Dictionary<string, int>());
                    animals[name].Add(area, neededFood);
                }
                animals[name][area] += neededFood;

            }
            else if (commandName == "Feed")
            {
                string name = commandproperties[0];
                int feeded = int.Parse(commandproperties[1]);
                if (animals.ContainsKey(name))
                {
                    foreach (var kvp in animals[name])
                    {
                        foreach (var item in kvp.Key)
                        {
                            kvp[Value] -= feeded;
                            if (kvp[Value]<=0)
                            {

                            }
                        }

                }
            }


            command = Console.ReadLine();
        }

    }
}
