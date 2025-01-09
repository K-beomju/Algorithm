using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int[]> inputs = new List<int[]>();

        while(true)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (numbers.Sum() == 0)
                break;

            inputs.Add(numbers.OrderBy(i => i).ToArray());
        }

        foreach(var numbers in inputs)
        {
            int a = numbers[0], b = numbers[1], c = numbers[2];
            string correct = Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2) ? "right" : "wrong";
            Console.WriteLine(correct);
        }
    }

}
