using System;
using System.Collections.Generic;

class AMinerTask
{
    static void Main()
    {
        Dictionary<string, int> resources = new Dictionary<string, int>();

        string resource = Console.ReadLine();
        while (resource != "stop")
        {
            int quantity = int.Parse(Console.ReadLine());
            if (!resources.ContainsKey(resource))
            {
                resources.Add(resource, 0);
            }
            resources[resource] += quantity;

            resource = Console.ReadLine();
        }
        foreach (var item in resources)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
