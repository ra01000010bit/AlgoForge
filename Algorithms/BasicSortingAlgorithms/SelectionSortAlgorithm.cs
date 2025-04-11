using AlgoForge.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.Algorithms.BasicSortingAlgorithms
{
    public class SelectionSortAlgorithm : BaseAlgorithm
    {
        public SelectionSortAlgorithm(int[] array) : base(array)
        {
        }

        public void SelectionSort(Func<int, int, bool> less)
        {
            ArgumentNullException.ThrowIfNull(less);

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (less(array[j], array[minIndex]))
                        minIndex = j;
                }

                SwapAlgorithm.Swap(ref array[i], ref array[minIndex]);
            }
        }
    }
}
