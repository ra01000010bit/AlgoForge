using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.Algorithms.BasicAlgorithms
{
    public class DecisionAlgorithm : BaseAlgorithm
    {
        public DecisionAlgorithm(int[] array) : base(array)
        {
        }

        public bool Decision(Predicate<int> predicate)
        {
            ArgumentNullException.ThrowIfNull(predicate);

            foreach (int item in array)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
