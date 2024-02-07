using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Problems
{
    public class AssignCookies
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int i = 0, j = 0, contentChildren = 0;
            while (i < g.Length && j < s.Length)
            {
                Console.WriteLine("valie of i: " + i);
                Console.WriteLine("valie of j: " + j);
                if (s[j] >= g[i])
                {
                    contentChildren++;
                    i++;
                }
                j++;
            }
            return contentChildren;
        }
    }
}
