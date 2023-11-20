using ADS.Algorithm.SortingAlgorithm;
using ADS.Problems;
using BenchmarkDotNet.Running;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        BubbleSort bubbleSort = new BubbleSort();
        int[] data = new int[] {-9,1,0,39,2,1};
        //for (int i = 0; i < 9; i++)
        //{
        //    data[i] = random.Next(20);
        //}
        int[] result = bubbleSort.SortAsc(data);
        foreach (int i in result)
        {
            Console.WriteLine("Result:{0}", i);
        }

        Console.WriteLine("-------------------------------------------");

        int[] result1 = bubbleSort.SortDsc(data);
        foreach (int i in result1)
        {
            Console.WriteLine("Result:{0}", i);
        }
    }
}