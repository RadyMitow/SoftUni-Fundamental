using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Order_by_age
{
    class OrderByAge
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] personInfo = comand.Split().ToArray();
                string personName = personInfo[0];
                Person person = persons.FirstOrDefault(p => p.ID == personInfo[1]);
                if (person == null)
                {
                    persons.Add(new Person()
                    {
                        Name = personInfo[0],
                        ID = personInfo[1],
                        Age = int.Parse(personInfo[2])
                    });
                }
                else
                {
                    person.Name = personInfo[0];
                    person.Age = int.Parse(personInfo[2]);
                }
                comand = Console.ReadLine();
            }
            foreach (var person in persons.OrderBy(p => p.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string result = $"{Name} with ID: {ID} is {Age} years old.";
            return result;
        }
    }
}
