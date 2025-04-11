using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoForge.Core.Localization;

namespace AlgoForge.Core.Utilities
{
    public static class OperatorType
    {
        public static string GetOperatorType()
        {
            Console.WriteLine(LanguageManager.Instance.GetMessage("AskForOperator"));
            string answear = Console.ReadLine();
            if (answear != null)
                return answear;
            return answear;
        }
    }
}
