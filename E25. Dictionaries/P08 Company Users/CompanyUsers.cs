using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompanyUsers
{
    static void Main()
    {
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
        string commnad = Console.ReadLine();
        while (commnad != "End")
        {
            string[] commandInfo = commnad.Split(' ').ToArray();
            string company = commandInfo[0];
            string employee = commandInfo[2];

            if (!companies.ContainsKey(company))
            {
                companies.Add(company, new List<string>());
            }
            if (!companies[company].Contains(employee))
            {
                companies[company].Add(employee);
            }

            commnad = Console.ReadLine();
        }

        foreach (var item in companies)
        {
            Console.WriteLine(item.Key);
            foreach (var employee in item.Value)
            {
                Console.WriteLine($"-- {employee}");
            }

        }
    }
}
