using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        List<string> quizList = new List<string>();
        for (int i = 0; i < count; i++)
        {
            string input = (Console.ReadLine());
            quizList.Add(input);
        }


        for (int i = 0; i < quizList.Count; i++)
        {
            string quiz = quizList[i];
            int total = 0;
            int score = 0;

            for (int j = 0; j < quiz.Length; j++) 
            {
                if (quiz[j] == 'O')
                {
                    score += 1;
                }
                if (quiz[j] == 'X')
                {
                    score = 0;
                }

                total += score;
            }
            Console.WriteLine(total);

        }
    }

}
