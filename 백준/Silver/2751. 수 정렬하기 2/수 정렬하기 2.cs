using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int temp = 0;
        int len = int.Parse(Console.ReadLine());


        //배열 생성 후 입력받기
        int[] input = new int[len];
        for (int i = 0; i < len; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(input);


        Console.WriteLine(string.Join("\n", input));

    }



}
