using BenchmarkDotNet.Attributes;
namespace ADS.Problems
{
    public class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.TryGetValue(complement, out int index))
                {
                    return new int[] { index, i };
                }
                numDict[nums[i]] = i;
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
