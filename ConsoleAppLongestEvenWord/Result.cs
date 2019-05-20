using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLongestEvenWord
{
    public class Result
    {
        /*
        * Complete the 'longestEvenWord' function below.
        *
        * The function is expected to return a STRING.
        * The function accepts STRING sentence as parameter.
        */

        public static string longestEvenWord(string sentence)
        {

            string[] words = sentence.Split(' ');

            string winner = string.Empty;

            foreach (var word in words)
            {
                bool evenWord = word.Length % 2 == 0;

                if (evenWord & word.Length > winner.Length)
                {
                    winner = word;
                }
            }

            return string.IsNullOrEmpty(winner) ? "00" : winner;
        }
    }
}
