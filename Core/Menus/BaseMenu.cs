using AlgoForge.Core.Interfaces;
using AlgoForge.Core.Localization;

namespace AlgoForge.Core.Menus
{
    public abstract class BaseMenu : IMenu
    {
        protected Dictionary<int, Action> MenuOptions = new();
        public abstract string Title { get; }
        /// <summary>
        /// Displays the menu and handles the user input.
        /// </summary>
        public virtual void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine($"----{Title}----");

            foreach (var option in MenuOptions.Keys)
            {
                string methodName = MenuOptions[option].Method.Name;

                string message = LanguageManager.Instance.GetMessage(methodName);

                Console.WriteLine($"{option}. {message}");
            }
            Console.WriteLine(LanguageManager.Instance.GetMessage("Quit"));

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || !MenuOptions.ContainsKey(choice))
            {
                Console.WriteLine(LanguageManager.Instance.GetMessage("Bad choice"));
            }

            if (choice == 0) return;

            MenuOptions[choice].Invoke();

            ShowMenu();
        }
    }
}
