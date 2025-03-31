using AlgoForge.AlgoForge.Core.Interfaces;

namespace AlgoForge.AlgoForge.Core.Menus
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
                Console.WriteLine($"{option}.{MenuOptions[option].Method.Name}");
            }
            Console.WriteLine("0. Kilépés");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || !MenuOptions.ContainsKey(choice))
            {
                Console.WriteLine("Helytelen választás, kérlek próbáld újra.");
            }

            if (choice == 0) return;

            MenuOptions[choice].Invoke();

            ShowMenu();
        }
    }
}
