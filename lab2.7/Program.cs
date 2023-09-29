using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть температуру в градусав С - ");
        double celsius = double.Parse(Console.ReadLine());

        
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Температура в градусах F - {fahrenheit}");
    }
}
