using System;

class CookingMasterclass
{
    static void Main(string[] args)
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        decimal flourPrice = decimal.Parse(Console.ReadLine());
        decimal eggPrice = decimal.Parse(Console.ReadLine());
        decimal apronPrice = decimal.Parse(Console.ReadLine());

        decimal subTotalFlour;
        decimal subTotalEggs;
        decimal subTotalApron;

        subTotalFlour = (students - (students / 5)) *flourPrice;
        subTotalEggs = students * 10 * eggPrice;
        subTotalApron = (int)(Math.Ceiling(students * 1.2)) * apronPrice;

        decimal totalSum = subTotalApron + subTotalEggs + subTotalFlour;

        if (totalSum<=budget)
        {
            Console.WriteLine($"Items purchased for {totalSum:F2}$.");
        }
        else
        {
            decimal difference = totalSum - budget;
            Console.WriteLine($"{difference:F2}$ more needed.");
        }

    }
}
