using AlgoForge.Core.Localization;

namespace AlgoForge.Core.Menus
{
    public class AdvancedAlgorithmsMenu : BaseMenu
    {
        public override string Title => LanguageManager.Instance.GetMessage("");
        public AdvancedAlgorithmsMenu()
        {
            MenuOptions.Add(1, RunCopyAlgorithm);
        }

        private void RunCopyAlgorithm()
        {

        }

    }
}
