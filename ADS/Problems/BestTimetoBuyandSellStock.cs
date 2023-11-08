using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Problems
{
    public class BestTimetoBuyandSellStock
    {
        public int BestTimetoBuyandSellStockMethod(int[] data)
        {
            int maxProfit = 0;
            int buy = data[0];
            for (int i = 1; i<data.Length; i++)
            {
                Console.WriteLine(data[i]);
                if (buy > data[i]) 
                    buy = data[i];
                if(maxProfit < data[i] - buy)
                    maxProfit = data[i]-buy;
            }
            return maxProfit;
        }
    }
}
