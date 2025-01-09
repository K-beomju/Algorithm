using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {     
       Console.WriteLine(Console.ReadLine().Split(' ').Where(x => x != string.Empty).ToArray().Length);
    
    }

}
