using System;
using System.Collections.Generic;

namespace Text_Segmentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> words = new Dictionary<string, bool>();

            words.Add("a",false);
            words.Add("is",false);
            words.Add("cat",false);
            words.Add("dog",false);

            string input = Console.ReadLine();

            int l = input.Length;
            bool[] DP = new bool[l+1];

            DP[l] = true;

            for (int i = l-1; i >=0; i--)
            {
                for (int j = i; j < i+3 && j <l; j++)
                {
                    if (words.ContainsKey(input.Substring(i, j - i + 1)) && DP[j + 1])
                    {
                        DP[i] = true;
                        break;
                    }
                }
            }

            Console.WriteLine(DP[0]);
        }
    }
}
