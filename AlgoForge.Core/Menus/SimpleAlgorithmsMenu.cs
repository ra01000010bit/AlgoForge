using AlgoForge.AlgoForge.Algorithms.Simple;
using AlgoForge.AlgoForge.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Core.Menus
{
    public class SimpleAlgorithmMenu : BaseMenu
    {
        public override string Title => "Egyszerű programozási tételek menu";
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleAlgorithmMenu"/> class.
        /// </summary>
        public SimpleAlgorithmMenu()
        {
            MenuOptions.Add(1, RunSummationAlgorithm);
            MenuOptions.Add(2, RunSelectionAlgorithm);
        }
        /// <summary>
        /// Runs the summation algorithm.
        /// </summary>
        private void RunSummationAlgorithm()
        {
            var generator = new ArrayGenerator();
            int[] numbers = generator.GenerateArray();

            var algorithm = new SummationAlgorithm();
            int result = algorithm.Summation(numbers, 0, (acc, num) => acc + num);

            Console.WriteLine($"A megszámlálás erdeménye: {result}");
            Console.ReadLine();
        }
        /// <summary>
        /// Runs the selection algorithm.
        /// </summary>
        private void RunSelectionAlgorithm()
        {
            var generator = new ArrayGenerator();
            int[] numbers = generator.GenerateArray();

            Console.WriteLine("Kérlek add meg a keresett számot:");
            var specificNumber = int.Parse(Console.ReadLine());

            var algorithm = new SelectionAlgorithm();

            Predicate<int> predicate = num => num == specificNumber;

            int result = algorithm.Selection(numbers, predicate);

            Console.WriteLine($"A keresett szám indexe: {result}");
            Console.ReadLine();
        }
    }
}
