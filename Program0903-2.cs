using System;
using System.Collections.Generic;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores;
            scores = new int[5];
            scores[1] = 5;
            Console.WriteLine(scores[0]);

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            float[] data_float;
            data_float = new float[3] { 1.1f, 2.2f, 3.3f };

            string[] data_str = new string[3] { "aaa", "bbb", "ccc" };

            // 3. .Length 추가
            for (int i = 0; i < data_float.Length; i++)
            {
                Console.WriteLine(data_float[i] + data_str[i]);
            }
            foreach (string v in data_str)
            {
                Console.WriteLine(v);
            }
        }
    }
}