using AlgoForge.AlgoForge.Algorithms.Simple;
using AlgoForge.AlgoForge.Core.Localization;
using AlgoForge.AlgoForge.Core.Menus;
using AlgoForge.AlgoForge.Core.Utilities;
using System.Reflection;
using System.Text.RegularExpressions;

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
            #region Language manager
            //LanguageManager.Instance.SelectLanguage(); bugged
            //Console.WriteLine(LanguageManager.Instance.GetMessage("Greeting"));
            #endregion
            #region Menu
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowMenu();
            #endregion


        }
    }
}