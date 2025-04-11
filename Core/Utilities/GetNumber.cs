using AlgoForge.Core.Localization;

namespace AlgoForge.Core.Utilities
{
    public class GetNumber
    {
        public int AskForANumber()
        {
            Console.WriteLine(LanguageManager.Instance.GetMessage("AskForANumber"));
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
