using System;
using System.Collections.Generic;

namespace Bronze1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().ToString()); // 파일 개수
            char[] std = Console.ReadLine().ToCharArray(); // 기준이 될 첫번째 패턴 입력값

            for (int i = 0; i < N - 1; i++)
            {
                char[] FileName = Console.ReadLine().ToCharArray();
                for (int j = 0; j < std.Length; j++)
                {
                    std[j] = (std[j] != FileName[j]) ? '?' : std[j];
                }
            }
            Console.WriteLine(std);
        }
    }
}