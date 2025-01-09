using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string S = Console.ReadLine();
        int index = 0;
        int[] counts = Enumerable.Repeat(-1, 26).ToArray();
        for (char a = 'a'; a <= 'z'; a++)
        {
            if(S.Contains(a) && counts[index] == -1)
            {
                counts[index] = S.IndexOf(a);
            }
            index++;
        }

        for(int i = 0; i < counts.Length; i++)
        {
            Console.Write(counts[i] + " ");
        }
    }

}
