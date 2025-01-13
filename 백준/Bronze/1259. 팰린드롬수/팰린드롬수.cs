using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> strings = new List<string>();
        while(true)
        {
            string word = Console.ReadLine();

            if (word == "0")
                break;

            strings.Add(word);
        }

  

        for (int i = 0; i < strings.Count; i++)
        {
            string a = strings[i];
            string b = string.Empty;
            for (int j = strings[i].Length - 1; j >= 0; j--)
            {
                b += a[j];
            }

            if(a == b)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            b = string.Empty;

        }
    }



}
