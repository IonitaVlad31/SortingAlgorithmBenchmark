using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace SortingAlgorithmBenchmark
{
    public class SelectionSort : ISortingAlgorithm
    {
        public string Nume => "Selection Sort";
        public void Sorteaza(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIdx])
                    {
                        minIdx = j;
                    }
                }

                if (minIdx != i)
                {
                    int temp = array[minIdx];
                    array[minIdx] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
