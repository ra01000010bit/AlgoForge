using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Algorithms.Basic
{
    internal class DecisionAlgorithms
    {
        public bool Decision(int[] x, Predicate<int> p)
        {
            ArgumentNullException.ThrowIfNull(p);
            int i = 0;
            while (i < x.Length && !p(x[i]))
            {
                i++;
            }
            return i < x.Length;
        }
    }
}
