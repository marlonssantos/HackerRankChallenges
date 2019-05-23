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
            string s = Console.ReadLine();

            string result = Result.TimeConversion(s);

            Console.WriteLine("\n**Output**");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
