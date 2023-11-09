using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Problems
{
    public class MajorityElement
    {
        public int MajorityElementMethod(int[] data)
        {
            int candidate=0;
            int count = 0;
            foreach (int i in data)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Current Element is {0}",i);
                if(count==0)
                {
                    candidate = i;
                }
                if(candidate == i)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                Console.WriteLine("Current candidate is {0}", candidate);
                Console.WriteLine("Current count is {0}", count);
            }
            var globalCount = 0;
            foreach (int i in data)
            {
                if(candidate == i)
                {
                    globalCount++;
                }
            }
            return globalCount > data.Length / 2 ? candidate: -1;
        }
    }
}
