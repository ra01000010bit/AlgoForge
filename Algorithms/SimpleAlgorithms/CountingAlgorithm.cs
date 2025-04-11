using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.Algorithms.BasicAlgorithms
{
    public class CountingAlgorithm : BaseAlgorithm
    {
        public CountingAlgorithm(int[] array) : base(array)
        {
        }

        public int Counting(Predicate<int> predicate)
        {
            ArgumentNullException.ThrowIfNull(predicate);
            int count = 0;
            foreach (int item in array)
            {
                if (predicate(item))
                    count++;
            }
            return count;
        }
    }
}
