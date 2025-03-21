using AlgoForge.AlgoForge.Core.Menus;
using System.Text.RegularExpressions;

namespace AlgoForge.AlgoForge.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Menu();
            Console.Clear();

        }
    }
}
