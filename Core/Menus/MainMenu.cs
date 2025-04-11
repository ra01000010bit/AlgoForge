using AlgoForge.Core.Localization;

namespace AlgoForge.Core.Menus
{
    public class MainMenu : BaseMenu
    {
        public override string Title => LanguageManager.Instance.GetMessage($"ProgramingAlgorithms");

        public MainMenu()
        {
            MenuOptions.Add(1, ShowAlgorithmMenu);
            MenuOptions.Add(2, ShowSortAlgorithmsMenu);
            MenuOptions.Add(3, ShowAdvancedAlgorithmsMenu);
        }

        private void ShowAlgorithmMenu()
        {
            new SimpleAlgorithmMenu().ShowMenu();
        }
        private void ShowSortAlgorithmsMenu()
        {
            new BasicSortAlgorithmsMenu().ShowMenu();
        }

        private void ShowAdvancedAlgorithmsMenu()
        {
            new AdvancedAlgorithmsMenu().ShowMenu();
        }
    }
}
