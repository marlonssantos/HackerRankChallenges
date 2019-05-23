using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptimeConversion
{
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
