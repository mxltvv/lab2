using System;

class Program
{
    static void Main()
    {
        Console.Write("ввдедіть число ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("введене число парние");
        }
        else
        {
            Console.WriteLine("введене число непарне");
        }
    }
}
