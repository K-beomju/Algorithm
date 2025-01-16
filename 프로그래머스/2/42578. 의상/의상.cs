using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
         Dictionary<string, int> clothesCnt = new Dictionary<string, int>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string type = clothes[i, 1];
            if(clothesCnt.ContainsKey(type))
            {
                clothesCnt[type]++;
            }
            else
            {
                clothesCnt[type] = 1;
            }
        }
        int answer = 1;

        foreach (var count in clothesCnt.Values) {
            answer *= (count + 1);
        }
        answer--;
        Console.WriteLine(answer);

        return answer;
    }
}