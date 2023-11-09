using ADS.Problems;
using BenchmarkDotNet.Running;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();


        MajorityElement obj = new MajorityElement();
        int[] data = new int[] {2,1,1, 1, 2, 2, 2,2,2,1,1,3,2};
        //for (int i = 0; i < 9; i++)
        //{
        //    data[i] = random.Next(20);
        //}
        int result = obj.MajorityElementMethod(data);
        Console.WriteLine("Result:{0}", result);
    }
}