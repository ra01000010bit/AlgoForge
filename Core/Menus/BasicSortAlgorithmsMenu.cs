using AlgoForge.Algorithms.BasicSortingAlgorithms;
using AlgoForge.Core.Localization;
using AlgoForge.Core.Utilities;

namespace AlgoForge.Core.Menus
{
    public class BasicSortAlgorithmsMenu : BaseMenu
    {
        public override string Title => LanguageManager.Instance.GetMessage("Simple Programing Algorithms");

        public BasicSortAlgorithmsMenu()
        {
            MenuOptions.Add(1, RunSelectionSortAlgorithm);
            MenuOptions.Add(2, RunBubbleSortAlgorithm);
            MenuOptions.Add(3, RunInsertSortAlgorithm);
        }
        private void RunSelectionSortAlgorithm()
        {
            int[] numbers = ArrayGenerator.GenerateArray();
            SelectionSortAlgorithm algorithm = new(numbers);

            Func<int, int, bool> ascending = (x, y) => x < y;
            algorithm.SelectionSort(ascending);

            Console.WriteLine("Rendezett tömb: " + string.Join(" ", numbers));

            Console.ReadLine();
        }
        private void RunBubbleSortAlgorithm()
        {
            int[] numbers = ArrayGenerator.GenerateArray();
            BubbleSortAlgorithm algorithm = new(numbers);

        }

        private void RunInsertSortAlgorithm()
        {

        }

    }
}
