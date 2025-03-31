using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Algorithms.Simple
{
    public class SelectionAlgorithm
    {
        // Kiválasztás
        public int Selection(int[] x, Predicate<int> p)
        {
            ArgumentNullException.ThrowIfNull(p);
            int i = 0;
            while (!p(x[i]))
            {
                i++;
            }
            return i;
        }
    }
}
