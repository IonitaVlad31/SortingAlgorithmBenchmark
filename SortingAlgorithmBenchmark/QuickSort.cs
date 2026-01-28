using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmBenchmark
{
    public class QuickSort : ISortingAlgorithm
    {
        public string Nume => "Quick Sort";
        public void Sorteaza(int[] array)
        {
            QuickSortAlgoritm(array, 0, array.Length - 1);
        }

        private void QuickSortAlgoritm(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSortAlgoritm(array, left, pivot - 1);
                QuickSortAlgoritm(array, pivot + 1, right);
            }
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp1;

            return i + 1;
        }
    }
}
