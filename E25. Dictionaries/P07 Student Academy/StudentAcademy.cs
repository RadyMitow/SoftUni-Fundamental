using System;
using System.Collections.Generic;
using System.Linq;

class StudentAcademy
{
    static void Main()
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double> >();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string student = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            if (!students.ContainsKey(student))
            {
                students.Add(student, new List<double>());
            }
            students[student].Add(grade);
        }
        foreach (var item in students)
        {
            if (item.Value.Average() < 4.50)
            {
                students.Remove(item.Key);
            }

        }       
        
        foreach (var item in students)
        {
            double avgGrade = item.Value.Average();
            Console.WriteLine($"{item.Key} -> {avgGrade:F2}");
        }
    }
}
