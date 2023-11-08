using ADS.Problems;
using BenchmarkDotNet.Running;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {

        TwoSum twoSum = new TwoSum();
        int[] data = new int[100000000];
        for (int i = 0; i < 99999999; i++)
        {
            data[i] = i;
        }
        Console.WriteLine(data.Length);

        int[] result = twoSum.TwoSumMethod(data, 180000000);
        Console.WriteLine("Result:{0},{1}", result[0], result[1]);
    }
}