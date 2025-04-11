using AlgoForge.Core.Localization;
using AlgoForge.Core.Menus;

namespace AlgoForge.AlgoForge.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ASCII text
            //Console.SetWindowSize(150, 30);
            //Console.SetBufferSize(150, 30);
            //AlgoForgeLogo.DisplayCyberpunkGreeting();
            #endregion
            #region JSON stuff
            //string jsonPath = "algorithms.json";
            //string jsonText = File.ReadAllText(jsonPath);

            //var algorithms = JsonSerializer.Deserialize<AlgorithmCollection>(jsonText);

            //foreach (var algo in algorithms.Algorithms)
            //{
            //    Console.WriteLine($"Algorithm: {algo.Name}");
            //    Console.WriteLine($"Input: {string.Join(", ", algo.Input)}");
            //    Console.WriteLine($"Output: {algo.Output}");
            //    Console.WriteLine("Steps:");
            //    foreach (var step in algo.Steps)
            //    {
            //        Console.WriteLine($" - {step}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Language manager
            LanguageManager.Instance.SelectLanguage();
            #endregion
            #region Menu
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowMenu();
            #endregion
        }
    }
}