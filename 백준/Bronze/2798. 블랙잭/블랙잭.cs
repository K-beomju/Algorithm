using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] cards = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int N = cards[0];
        int M = cards[1];
        if (N < 3 || N > 100 || M < 10 || M > 300000) return;

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 100000)
                return;
        }

        int answer = 0;
        List<int> values = new List<int>();

        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    // w
                    answer = numbers[i] + numbers[j] + numbers[k];
                    if(answer == M)
                    {
                        Console.WriteLine(answer);
                        return;
                    }
                    if (answer > M)
                        continue;

                    values.Add(answer);
                }
            }
        }

        int value = values.OrderBy(x =>(M - x)).First();
        Console.WriteLine(value);

    }



}
