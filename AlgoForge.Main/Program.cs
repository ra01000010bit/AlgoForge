using System.Text.RegularExpressions;

namespace AlgoForge.AlgoForge.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Welcome massage + start menu

            Console.WriteLine("Hello");

            Console.WriteLine("Kérlek válassza az alábbi menü pontok közül!");
            Console.WriteLine("1. Egyszerű programozási tételek.");
            Console.WriteLine("2. Összetett programozási tételek.");
            Console.WriteLine("3. Programozási tételek össze építése");

            // int mainAnswer = int.Parse(Console.ReadLine());
            Console.Clear();
            #endregion
        }
    }
}
