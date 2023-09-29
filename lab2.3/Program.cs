using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть годину - ");
        int h = int.Parse(Console.ReadLine());

        if (h >= 0 && h < 6)
        {
            Console.WriteLine("Good night <3");
        }
        else if (h >= 6 && h < 12)
        {
            Console.WriteLine("Good morning <3");
        }
        else if (h >= 12 && h < 18)
        {
            Console.WriteLine("Good afternonn <3");
        }
        else if (h >= 18 && h < 24)
        {
            Console.WriteLine("Good evening <3");
        }
        else
        {
            Console.WriteLine("Некоректний час. Введіть число від 0 до 23.");
        }
    }
}
