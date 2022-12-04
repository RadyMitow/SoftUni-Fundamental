using System;
using System.Linq;
using System.Text.RegularExpressions;

internal class PasswordValidator
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();
        Regex regex = new Regex(@"\w+");
        var match = regex.Match(password);

        string command = Console.ReadLine();
        while (command != "Complete")
        {
            string[] commandInfo = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string commandName = commandInfo[0];
            if (commandName == "Validation")
            {
                if (password.Length < 8)
                {
                    Console.WriteLine("Password must be at least 8 characters long!");
                }
                if (!match.Success)
                {
                    Console.WriteLine("Password must consist only of letters, digits and _!");
                }
                if (!password.Any(char.IsUpper))
                {
                    Console.WriteLine("Password must consist at least one uppercase letter!");
                }
                if (!password.Any(char.IsLower))
                {
                    Console.WriteLine("Password must consist at least one lowercase letter!");
                }
                if (!password.Any(char.IsDigit))
                {
                    Console.WriteLine("Password must consist at least one digit!");
                }
            }
            else if (commandName == "Replace")
            {
                char charToreplace = char.Parse(commandInfo[1]);
                int asciiToBeAdded = int.Parse(commandInfo[2]);
                int index = password.IndexOf(charToreplace);
                if (index != -1)
                {
                    char newToreplace = (char)(charToreplace + asciiToBeAdded);
                    password = password.Replace(charToreplace, newToreplace);
                    Console.WriteLine(password);
                }
            }
            else if (commandName == "Insert")
            {
                int index = int.Parse(commandInfo[1]);
                string strToreplace = commandInfo[2];
                if (index < password.Length)
                {
                    password = password.Insert(index, strToreplace);
                }
                Console.WriteLine(password);
            }
            else if (commandName == "Make")
            {
                string commandProperty = commandInfo[1];
                int index = int.Parse(commandInfo[2]);
                if (index < password.Length)
                {
                    string substring = password.Substring(index, 1);
                    if (commandProperty == "Upper")
                    {
                        substring = substring.ToUpper();
                        password = password.Remove(index, 1);
                        password = password.Insert(index, substring);
                        Console.WriteLine(password);
                    }
                    else if (commandProperty == "Lower")
                    {
                        substring = substring.ToLower();
                        password = password.Remove(index, 1);
                        password = password.Insert(index, substring);
                        Console.WriteLine(password);
                    }
                }
            }
            command = Console.ReadLine();
        }
    }
}
