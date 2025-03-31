using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Core.Menus
{
    public class MainMenu : BaseMenu
    {
        public override string Title => "Fo Menu";

        public MainMenu()
        {
            
            MenuOptions.Add(1, ShowAlgorithmMenu);
            MenuOptions.Add(2, ShowSortAlgorithmsMenu);
        }

        private void ShowAlgorithmMenu()
        {
            new SimpleAlgorithmMenu().ShowMenu();
        }
        private void ShowSortAlgorithmsMenu()
        {
            new SortAlgorithmsMenu().ShowMenu();
        }
    }
}
