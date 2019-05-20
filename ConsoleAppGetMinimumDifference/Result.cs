using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGetMinimumDifference
{
    public class Result
    {
        /*
         * Complete the 'getMinimumDifference' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY a
         *  2. STRING_ARRAY b
         */

        public static List<int> getMinimumDifference(List<string> a, List<string> b)
        {

            List<int> minDiff = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (a.ElementAt(i).Length != b.ElementAt(i).Length)
                {
                    minDiff.Add(-1);
                    continue;
                }

                int diffCount = 0;

                for (int j = 0; j < a.ElementAt(i).Length; j++)
                {
                    if (!b.ElementAt(i).Contains(a.ElementAt(i)[j].ToString()))
                    {
                        diffCount++;
                    }
                }

                minDiff.Add(diffCount);
            }

            return minDiff;
        }
    }
}
