using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.Algorithms.BasicAlgorithms
{
    public class LinearSearchAlgorithm : BaseAlgorithm
    {
        public LinearSearchAlgorithm(int[] array) : base(array)
        {
        }

        public bool LinearSearch(Predicate<int> predicate, out int index)
        {
            ArgumentNullException.ThrowIfNull(predicate);

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    index = i;
                    return true;
                }
            }
            index = -1;
            return false; 
        }
    }
}
