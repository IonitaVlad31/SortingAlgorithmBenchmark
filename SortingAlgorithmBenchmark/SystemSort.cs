using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmBenchmark
{
    public class SystemSort : ISortingAlgorithm
    {
        public string Nume => "C# Native Sort";
        public void Sorteaza(int[] array)
        {
            Array.Sort(array);
        }
    }
}
