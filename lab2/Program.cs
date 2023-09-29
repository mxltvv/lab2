using System;

class Program
{
    static void Main()
      
    {
        Console.Write("Введіть перше число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 >= 1 && number1 <= 31 && number2 >= 1 && number2 <= 12)
        {
            Console.WriteLine($"{number1} може бути днем, а {number2} може бути місяцем");
        }
        else
        {
            Console.WriteLine($"{number1} та {number2} не можуть бути днем та місяцем");
        }
    }
    
}

