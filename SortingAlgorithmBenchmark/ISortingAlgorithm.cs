using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmBenchmark
{
    public interface ISortingAlgorithm
    {
        string Nume { get; }
        void Sorteaza(int[] array);
    }
}
