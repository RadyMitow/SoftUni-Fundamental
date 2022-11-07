using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        string[] inputInfo = Console.ReadLine().Split(':').ToArray();

        while (inputInfo[0] != "end")
        {
            string courseName = inputInfo[0].Trim();
            string student = inputInfo[1].Trim();

            if (!courses.ContainsKey(courseName))
            {
                courses.Add(courseName, new List<string>());
            }
            courses[courseName].Add(student);

            inputInfo = Console.ReadLine().Split(':').ToArray();
        }
        foreach (var item in courses)
        {
            int numberOfStudents = item.Value.Count;
            Console.WriteLine($"{item.Key}: {numberOfStudents}");

            foreach (var student in item.Value)
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}
