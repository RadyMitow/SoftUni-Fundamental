using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniParking
{
    static void Main()
    {
        Dictionary<string, string> users = new Dictionary<string, string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string[] commandInfo = Console.ReadLine().Split().ToArray();
            string command = commandInfo[0];
            if (command == "register")
            {
                string user = commandInfo[1];
                string licencePlate = commandInfo[2];
                if (!users.ContainsKey(user))
                {
                    users.Add(user, licencePlate);
                    Console.WriteLine($"{user} registered {licencePlate} successfully");
                }
                else Console.WriteLine($"ERROR: already registered with plate number {users[user]}");

            }
            else if (command == "unregister")
            {
                string user = commandInfo[1];
                if (users.ContainsKey(user))
                {
                    users.Remove(user);
                    Console.WriteLine($"{user} unregistered successfully");
                }
                else Console.WriteLine($"ERROR: user {user} not found");
            }
        }
        foreach (var item in users)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }
}