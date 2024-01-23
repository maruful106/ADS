using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Problems
{
    public class RomanNumber
    {
        public int RomanToIntValue(string roman)
        {
            Dictionary<string, int> map = new Dictionary<string, int>()
            {
                {"I",1 }, {"V",5}, {"X",10}, {"L",50}, {"C",100},{"D",500},{"M",1000}
            };

            int totalCount = 0;
            foreach (char word in roman)
            {
                totalCount = totalCount + map[word.ToString()];
            }
            Console.WriteLine(totalCount);
            return totalCount;
        }
    }
}
