using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLongestEvenWord
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> wordCollection = new List<string>()
            {
                "It is a pleasant day today", "You can do it the way you like", "hey"
            };

            foreach (string word in wordCollection)
            {
                string result = Result.longestEvenWord(word);

                Console.WriteLine(result);
            }

            Console.ReadLine();



            //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //    string sentence = Console.ReadLine();
            //    string result = Result.longestEvenWord(sentence);
            //    textWriter.WriteLine(result);
            //    textWriter.Flush();
            //    textWriter.Close();

        }
    }
}