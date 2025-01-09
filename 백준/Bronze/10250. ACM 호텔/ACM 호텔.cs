using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[,] test = new int[count, 3];
        for (int i = 0; i < count; i++)
        {
            string s = Console.ReadLine();

            test[i, 0] = int.Parse(s.Split(' ')[0]);
            test[i, 1] = int.Parse(s.Split(' ')[1]);
            test[i, 2] = int.Parse(s.Split(' ')[2]);
        }

        for (int i = 0; i < test.GetLength(0); i++)
        {
            // 호텔 층 수, 각 층의 방 수, 몇번 째 손님
            int H = test[i, 0];
            int W = test[i, 1];
            int N = test[i, 2];

            int roomNumber = 1;
            // 손님이 층보다 높다면 계산
            if (N > H)
            {
                while (N > H)
                {
                    N -= H;
                    roomNumber++;
                }
            }
            else
            {
            }

            if (roomNumber >= 10)
                Console.WriteLine(N + "" + roomNumber);
            else
                Console.WriteLine(N + "0" + roomNumber);

        }

    }

}
