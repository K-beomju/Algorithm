using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();
        double result = 0;
        char[] arr = a.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            result += GetIndexAlphabet(arr[i]) * Math.Pow(31, i);
        }
        Console.WriteLine(result);
    }

    static int GetIndexAlphabet(char a)
    {
        char ch;
        int num = 1;
        for(ch = 'a'; ch <= 'z'; ch++)
        {
            if(a == ch)
            {
                return num;
            }
            num++;
        }

        return -1;
    }

}
