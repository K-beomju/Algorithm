using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        ////참가자 수
        int entry = int.Parse(Console.ReadLine());

        if (entry < 1 || entry > Math.Pow(10, 9))
        {
            return;
        }

        // 티셔츠 사이즈
        int[] tShirtSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int totalShirtSize = 0;
        for (int i = 0; i < tShirtSize.Length; i++)
        {
            totalShirtSize += tShirtSize[i];
            if (tShirtSize[i] < 0 && tShirtSize[i] > entry)
                return;
        }

        if (totalShirtSize != entry)
        {
            return;
        }


        // 티셔츠 묶음, 펜 묶음 수
        int[] tShirtAndPenBundle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (tShirtAndPenBundle[0] < 2 || tShirtAndPenBundle[1] > Math.Pow(10, 9))
        {
            return;
        }



        // 티셔츠 묶음 수, 펜 묶음 
        int tShirtBundle = tShirtAndPenBundle[0];
        int penBundle = tShirtAndPenBundle[1];

        int resultShirt = 0;

        for (int i = 0; i < tShirtSize.Length; i++)
        {
            int size = tShirtSize[i];

            // 나머지 값, 목값
            int remainder = size % tShirtBundle;
            int quotient = size / tShirtBundle;

            // 나머지 값이 0보다 크다면 +1 더함
            resultShirt += remainder > 0 ? quotient + 1 : quotient;

        }

        // 몫 나머지
        Console.WriteLine(resultShirt);

        Console.WriteLine(entry / penBundle + " " + entry % penBundle);
    }

}
