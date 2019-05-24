using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMisc
{
    public class Result
    {public static string TimeConversion(string s)
        {
            string[] timeTokens = s.Split(':');
            string hour = timeTokens[0];
            string min = timeTokens[1];
            string sec = timeTokens[2];

            if (sec.Contains("AM") && Convert.ToInt16(hour) <= 11)
            {
                sec = sec.Replace("AM", "");
            }

            if (sec.Contains("AM") && Convert.ToInt16(hour) == 12)
            {
                hour = $"0{(Convert.ToInt16(hour) - 12).ToString()}";
                sec = sec.Replace("AM", "");
            }

            if (sec.Contains("PM") && Convert.ToInt16(hour) <= 11)
            {
                hour = (Convert.ToInt16(hour) + 12).ToString();
                sec = sec.Replace("PM", "");
            }

            if (sec.Contains("PM") && Convert.ToInt16(hour) == 12)
            {
                sec = sec.Replace("PM", "");
            }

            return $"{hour}:{min}:{sec}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Given a time in -hour AM / PM format, convert it to military(24 - hour) time.
            // Note: Midnight is 12:00:00AM on a 12 - hour clock, and 00:00:00 on a 24 - hour clock.Noon is 12:00:00PM on a 12 - hour clock, and 12:00:00 on a 24 - hour clock.
            // Function Description
            // Complete the timeConversion function in the editor below.It should return a new string representing the input time in 24 hour format.

            string s = Console.ReadLine();

            string result = Result.TimeConversion(s);

            Console.WriteLine("\n**Output**");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
