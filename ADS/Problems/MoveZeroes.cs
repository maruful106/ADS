using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Problems
{
    public class MoveZeroes
    {
        public int[] MoveZeroesMethod(int[] movements)
        {
            int pointer = 0;
            for (int i = 0; i < movements.Length; i++)
            {
                if (movements[i] != 0)
                {
                    movements[pointer] = movements[i];
                    pointer++;
                }
            }
            for(int i = pointer; i< movements.Length; i++)
            {
                movements[i] = 0;
            }
            return movements;
        }
    }
}
