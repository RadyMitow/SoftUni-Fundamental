using System;
using System.Text.RegularExpressions;

internal class BossRush
{
    static void Main(string[] args)
    {
        string patern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";
        Regex regex = new Regex(patern);
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string bossinfo = Console.ReadLine();
            var match = regex.Match(bossinfo);
            if (match.Success)
            {
                string bossName = match.Groups["name"].Value;
                string bossTitle = match.Groups["title"].Value;

                Console.WriteLine($"{bossName}, The {bossTitle}");
                Console.WriteLine($">> Strength: {bossName.Length}");
                Console.WriteLine($">> Armor: {bossTitle.Length}");

            }
            else { Console.WriteLine("Access denied!"); }

        }
    }
}