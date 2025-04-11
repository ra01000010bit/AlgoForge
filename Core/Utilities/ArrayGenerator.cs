using AlgoForge.Core.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoForge.Core.Exceptions;

namespace AlgoForge.Core.Utilities
{
    public static class ArrayGenerator
    {
        public static int[] GenerateArray()
        {
            Console.WriteLine(LanguageManager.Instance.GetMessage("AskForNumbers"));

                string input = Console.ReadLine();
                return input.Split(' ')
                            .Where(s => int.TryParse(s, out _))
                            .Select(int.Parse)
                            .ToArray();
  
            
        }
    }
}
