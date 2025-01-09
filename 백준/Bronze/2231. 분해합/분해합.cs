using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        bool result = false;
        if (N < 1 || N > 1000000) return;
        // Brute Force
        for (int i = 0; i < N; i++)
        {
            int value = i;
            int count = value;
            while (value > 0)
            {
                int digit = value % 10;
                count += digit;
                value /= 10;
            }

            if (count == N)
            {
                result = true;
                Console.WriteLine(i);
                break;
            }
          
        }

        if(!result)
        {
            Console.WriteLine(0);
        }
    }

   

}
