using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть число - ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("повинно бути натуральним числом");
        }
        else
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"сума перших {n} чисел: {sum}");
        }
    }
}
