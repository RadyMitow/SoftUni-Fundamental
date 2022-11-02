using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Students
{
    class Students
    {
        static void Main()
        {
            List<Student> Students = new List<Student>();
            Student student;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(' ').ToArray();
                student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
                Students.Add(student);
            }
            foreach (var item in Students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        override public string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
