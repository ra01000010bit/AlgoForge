using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Core.Utilities
{
    public class ArrayGenerator
    {
        public int[] GenerateArray()
        {
            Console.Write("Kérlek add meg a számokat szó közökkel elválasztva!");
            string input = Console.ReadLine();
            return input.Split(' ')
                        .Where(s => int.TryParse(s, out _))
                        .Select(int.Parse)
                        .ToArray();
        }
    }
}
