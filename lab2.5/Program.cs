using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть довжину прямокутника - ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("ввдедіть ширину прямокутника - ");
        double width = double.Parse(Console.ReadLine());

       
        double area = length * width;

        Console.WriteLine($"Площа прямокутника: {area}");
    }
}
