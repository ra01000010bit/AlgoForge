using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Core.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message)
        {
            Console.WriteLine("Invalid input. Please enter 1 or 2.");
        }
    }
}
