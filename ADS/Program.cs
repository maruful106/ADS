using ADS.Problems;
using BenchmarkDotNet.Running;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();


        MoveZeroes obj = new MoveZeroes();
        int[] data = new int[] {-9,1,0,39,2,1};
        //for (int i = 0; i < 9; i++)
        //{
        //    data[i] = random.Next(20);
        //}
        int[] result = obj.MoveZeroesMethod(data);
        foreach (int i in result)
        {
            Console.WriteLine("Result:{0}", i);
        }
    }
}