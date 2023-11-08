using ADS.Problems;
using BenchmarkDotNet.Running;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        BestTimetoBuyandSellStock obj = new BestTimetoBuyandSellStock();
        int[] data = new int[10];
        for (int i = 0; i < 9; i++)
        {
            data[i] = random.Next(20);
        }
        int result = obj.BestTimetoBuyandSellStockMethod(data);
        Console.WriteLine("Result:{0}", result);
    }
}