using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftAntimalwareEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Algorithm.SortingAlgorithm
{
    /// <summary>
    /// Bubble sort is a simple sorting algorithm that works by repeatedly stepping through the list of elements, 
    /// comparing each pair of adjacent items, and swapping them if they are in the wrong order
    /// 
    /// ##### procedural code #####
    /// procedure bubbleSort(list: array of comparable)
    /// n:= lenght(list)
    /// repeat
    ///     swapped:= false
    ///     for i:= 1 to n-1
    ///         if list[i-1]> list[i]
    ///             swap(list[i-1], list[i])
    ///             swapped:= true
    ///     end for
    ///     n:= n-1
    /// until dnot swapped
    /// 
    /// </summary>
    /// <param name="InputArray">Array of integer which need to be sorted using bubble sort.</param>
    /// <returns>Sorted Array.</returns>
    public class BubbleSort
    {
        public int[] SortAsc(int[] list) 
        {
            int n = list.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (list[i] < list[i - 1])
                    {
                        int temp = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
            return list;
        }
        public int[] SortDsc(int[] list)
        {
            int n = list.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (list[i] > list[i - 1])
                    {
                        int temp = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
            return list;
        }
    }
}
