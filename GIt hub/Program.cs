using System;

class Program
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
        {
            Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
        }
        else
        {
            Console.WriteLine("Try again!!.");
        }
    }
}
