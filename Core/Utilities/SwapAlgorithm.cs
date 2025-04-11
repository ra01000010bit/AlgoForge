using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.Core.Utilities
{
    public static class SwapAlgorithm
    {
        public static void Swap(ref int first, ref int second)
        {
            int tmep = first;
            first = second;
            second = tmep;
        }
    }
}
