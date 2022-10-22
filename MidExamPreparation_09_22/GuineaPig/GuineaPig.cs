using System;


namespace GuineaPig
{
    class GuineaPig
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal pigweight = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                food -= 0.3m;

                if (i % 2 == 0)
                {
                    hay -= food * 0.05m;
                }

                if (i % 3 == 0)
                {
                    cover -= pigweight / 3m;
                }

                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    break;

                }
            }

            if (food <= 0 || hay <= 0 || cover <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:F2}, Hay: {hay:F2}, Cover: {cover:F2}.");
            }
        }
    }
}
