using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        
    int[] answer = new int[commands.GetLength(0)];

        for (int a = 0; a < commands.GetLength(0); a++)
        {
            int i = commands[a, 0];
            int j = commands[a, 1];
            int k = commands[a, 2];

            int[] numbers = new int[j - i + 1];
            int count = 0;

            for (int b = i; b <= j; b++)
            {
                numbers[count] = array[b - 1];
                count++;

            }

            Array.Sort(numbers);
            answer[a] = numbers[k - 1];
        }

        return answer;
    }
}