using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.Algorithms.BasicAlgorithms
{
    public class MaximumSelectionAlgorithm : BaseAlgorithm
    {
        public MaximumSelectionAlgorithm(int[] array) : base(array)
        {
        }

        public int MaximumSelection(Func<int, int, bool> less)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array has no items");
            }

            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (less(array[maxIndex], array[i]))
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
