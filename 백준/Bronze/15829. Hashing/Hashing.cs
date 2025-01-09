using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        long r = 1, M = 1234567891, hash = 0;
        Console.ReadLine();
        string str = Console.ReadLine();

        foreach (char c in str)
        {
            hash = (hash + (c - 96) * r) % M;
            r = (r * 31) % M;
        }
        Console.WriteLine(hash);
    }


}
