using System;
using System.Text;

class CaesarCipher
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            int temp = 0;

            temp +=input[i] + 3;
            sb.Append((char)(temp));
            

        }
        string cipher = sb.ToString();
        Console.WriteLine(cipher);

    }
}
