using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.Algorithms.BasicAlgorithms
{
    public  class SummationAlgorithm : BaseAlgorithm
    {
        public SummationAlgorithm(int[] array) : base(array)
        {
        }

        public int Summation(int initialValue, Func<int, int , int> operation)
        {
            ArgumentNullException.ThrowIfNull(operation);

            int result = initialValue;

            foreach (int item in array)
            {
                result = operation(result, item);
            }

            return result;
        }
    }
}
