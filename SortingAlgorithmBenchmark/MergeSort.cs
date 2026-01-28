using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmBenchmark
{
    public class MergeSort : ISortingAlgorithm
    {
        public string Nume => "Merge Sort";
        public void Sorteaza(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                Sort(array, left, mid);
                Sort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i) L[i] = array[left + i];
            for (int j = 0; j < n2; ++j) R[j] = array[mid + 1 + j];

            int k = left, x = 0, y = 0;
            while (x < n1 && y < n2)
            {
                if (L[x] <= R[y]) array[k++] = L[x++];
                else array[k++] = R[y++];
            }
            while (x < n1) array[k++] = L[x++];
            while (y < n2) array[k++] = R[y++];
        }
    }
}
