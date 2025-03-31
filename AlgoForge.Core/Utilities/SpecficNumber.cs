using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Core.Utilities
{
    public class SpecficNumber
    {
        public int SpecNumber()
        {
            Console.WriteLine("Kérlek add meg a keresett számot");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
