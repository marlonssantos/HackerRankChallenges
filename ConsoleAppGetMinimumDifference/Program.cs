using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppGetMinimumDifference
{
    class Program
    {
        public static void Main(string[] args)
        {

            // The challenge is to figure out the minimum difference between the word in the a and b collections,
            // then display then as the count of differences. when the length of the words are not the same, 
            // return -1. 
            // For example, for the collections:
            // "a", "jk", "abb", "mn", "abc"
            // "bb", "kj", "bbc", "op", "def"
            // Expected Input:
            //  5
            //  a
            //  jk
            //  abb
            //  mn
            //  abc
            //  5
            //  bb
            //  kj
            //  bbc
            //  op
            //  def
            // The output will be:
            // -1, 0, 1, 2, 3


            int aCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> a = new List<string>();

            for (int i = 0; i < aCount; i++)
            {
                string aItem = Console.ReadLine();
                a.Add(aItem);
            }

            int bCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> b = new List<string>();

            for (int i = 0; i < bCount; i++)
            {
                string bItem = Console.ReadLine();
                b.Add(bItem);
            }

            List<int> result = Result.getMinimumDifference(a, b);

            Console.WriteLine("\n**Output**");
            Console.WriteLine(String.Join("\n", result));
            Console.ReadLine();

        }
    }
}