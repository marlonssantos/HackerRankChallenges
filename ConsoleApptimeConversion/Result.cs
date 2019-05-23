using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptimeConversion
{
    public class Result
    {
        public static string TimeConversion(string s)
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
}
