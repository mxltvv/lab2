using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть 1 число - ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("введіть 2 число - ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("введіть 3 число - ");
        int num3 = int.Parse(Console.ReadLine());

       
        int min = Math.Min(Math.Min(num1, num2), num3);

       
        int max = Math.Max(Math.Max(num1, num2), num3);

        Console.WriteLine($"мінімальне значення: {min}");
        Console.WriteLine($"максимальне значення: {max}");
    }
}
