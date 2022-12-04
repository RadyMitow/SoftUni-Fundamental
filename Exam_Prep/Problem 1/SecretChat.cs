using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class SecretChat
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] commandInfo = command.Split(new[] { ":|:" }, StringSplitOptions.RemoveEmptyEntries);
                string  commandName = commandInfo[0];
                if (commandName == "InsertSpace")
                {
                    int index = int.Parse(commandInfo[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (commandName == "Reverse")
                {
                    string substring = commandInfo[1];
                    int startIndex = message.IndexOf(substring);
                    if (startIndex != -1)
                    {
                        message = message.Remove(startIndex, substring.Length);
                        message += string.Join("", substring.Reverse());

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "ChangeAll")
                {
                    string substring = commandInfo[1];
                    string replesment = commandInfo[2];

                    message = message.Replace(substring, replesment);

                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
