using ADS.Algorithm.SortingAlgorithm;
using ADS.Problems;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Symbols;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        RomanNumber romanNumber = new RomanNumber();
        int result = romanNumber.RomanToIntValue("XXVIIMCD");
    }
}