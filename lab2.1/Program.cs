using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть число - ");
        double number = double.Parse(Console.ReadLine());

        
        string numberString = number.ToString("F2");

        
        char digit1 = numberString[3];
        char digit2 = numberString[4];

        
        int num1 = int.Parse(digit1.ToString());
        int num2 = int.Parse(digit2.ToString());

        
        int sum = num1 + num2;

        Console.WriteLine($"{digit1} + {digit2} = {sum}");
    }
}
