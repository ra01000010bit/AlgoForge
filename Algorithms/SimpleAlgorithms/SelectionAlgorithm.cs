using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.Algorithms.BasicAlgorithms
{
    public class SelectionAlgorithm : BaseAlgorithm
    {
        public SelectionAlgorithm(int[] array) : base(array)
        {
        }

        public int Selection(Predicate<int> predicate)
        {
            ArgumentNullException.ThrowIfNull(predicate);

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    return i;
                }
            }

            throw new InvalidOperationException("Predicate is not satisfied.");
        }
    }
}
