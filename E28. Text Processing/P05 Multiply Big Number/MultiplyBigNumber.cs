using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MultiplyBigNumber
{
    static void Main()
    {
        string number = Console.ReadLine();
        int multiplier = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int temp = 0;

        if (number == "0" || multiplier== 0)
        {
            Console.WriteLine(0);
            return;
        }

        for (int i = number.Length-1; i >= 0; i--)
        {
            int digit = int.Parse(number[i].ToString());
            int result = (digit * multiplier);
            if (result + temp < 10 )
            {
                result += temp;
                temp = 0;
                sb.Append(result.ToString());
            }
            else 
            {
                result += temp;
                temp = result / 10;
                sb.Append((result % 10).ToString());
            }
        }
        if (temp>0)
        {
            sb.Append(temp.ToString());
        }
        List<char> product = sb.ToString().ToList();
        product.Reverse();

        foreach (var charecter in product)
        {
            Console.Write(charecter);
        }
    }
}
