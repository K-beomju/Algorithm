using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        long N = long.Parse(Console.ReadLine()); // N이 매우 클 수 있으므로 long 사용
        if (N < 1 || N > 1000000000) return;

        long hexagon = 1;
        long k = 1;

        while(N > hexagon)
        {
            hexagon += 6 * k;
            k++;
        }
        Console.WriteLine(k);



    }



}
