using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Algorithms.Simple
{
    public class SummationAlgorithm
    {
        // Sorozatszámítás
        public int Summation(int[] x,int value0, Func<int, int, int> operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException();
            }
            int value = 0;
            for (int i = 0; i <= x.Length - 1; i++)
            {
                value = operation(value, x[i]);
            }
            return value;
        }
    }
}
