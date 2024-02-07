using ADS.Algorithm.SortingAlgorithm;
using ADS.Problems;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Symbols;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        AssignCookies assignCookies = new AssignCookies();
        // Example 1
        //int[] g1 = { 1, 2, 3 };// children
        //int[] s1 = { 1, 1 };// cookies
        //Console.WriteLine(assignCookies.FindContentChildren(g1, s1)); // Output: 1

        // Example 2
        int[] g2 = { 1, 2 };
        int[] s2 = { 1, 2, 3 };
        Console.WriteLine(assignCookies.FindContentChildren(g2, s2)); // Output: 2
    }
}