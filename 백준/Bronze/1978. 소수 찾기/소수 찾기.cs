using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        if (count > 100) return;

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int decimalCount = 0;

        for (int i = 0; i < count; i++)
        {
            if (isPrime(numbers[i]))
            {
                decimalCount++;
            }
        }

        Console.WriteLine(decimalCount);
    }

    public static bool isPrime(int n)
    {
        if (n == 1) return false;

        int nr = (int)Math.Sqrt(n);
        for (int i = 2; i <= nr; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

}
