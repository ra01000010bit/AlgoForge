using AlgoForge.Algorithms.BasicAlgorithms;
using AlgoForge.Core.Localization;
using AlgoForge.Core.Predicates;
using AlgoForge.Core.Utilities;
using AlgoForge.Core.Utilities.Predicates.SimpleAlgorithmsPredicates;


namespace AlgoForge.Core.Menus
{
    public class SimpleAlgorithmMenu : BaseMenu
    {
        public override string Title => LanguageManager.Instance.GetMessage("SimpleAlgorithms");
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleAlgorithmMenu"/> class.
        /// </summary>
        public SimpleAlgorithmMenu()
        {
            MenuOptions.Add(1, RunSummationAlgorithm);
            MenuOptions.Add(2, RunSelectionAlgorithm);
            MenuOptions.Add(3, RunDecisionAlgorithm);
            MenuOptions.Add(4, RunLinearSearchAlgorithm);
            MenuOptions.Add(5, RunCountingAlgorithm);
            MenuOptions.Add(6, RunMaximumSelectionAlgorithm);
        }

        private void RunSummationAlgorithm()
        {
            Console.Clear();

            string operationType = OperatorType.GetOperatorType();

            int[] numbers = ArrayGenerator.GenerateArray();

            SummationAlgorithm algorithm = new(numbers);

            var operations = new Dictionary<string, Func<int, int, int>>
            {
                { "+", SummationPredicates.Addition },
                { "-", SummationPredicates.Subtraction },
                { "*", SummationPredicates.Multiplication }
            };

            if (operations.ContainsKey(operationType))
            {
                int result = algorithm.Summation(operationType == "*" ? 1 : 0, operations[operationType]);

                Console.WriteLine(LanguageManager.Instance.GetMessage("TheResult" + $" {result}."));
            }

            Console.ReadLine();
            #region Prev.Solution
            //var operation = new OperatorType();
            //string operationType = operation.GetOperatorType();

            //int[] numbers = ArrayGenerator.GenerateArray();

            //var algorithm = new SummationAlgorithms(numbers);
            ////int result = algorithm.Summation(0, SummationPredicates.Addition);
            //int result;
            //switch (operationType)
            //{
            //    case "+":
            //        result = algorithm.Summation(0, SummationPredicates.Addition);
            //        break;
            //    case "-":
            //        result = algorithm.Summation(0, SummationPredicates.Subtraction);
            //        break;
            //    case "*":
            //        result = algorithm.Summation(1, SummationPredicates.Multiplication);
            //        break;
            //    default:
            //        Console.WriteLine(LanguageManager.Instance.GetMessage("UnknownOperator"));
            //        return;
            //}

            //Console.WriteLine($"A megszámlálás erdeménye: {result}");
            //Console.ReadLine();
            #endregion
        }
        private void RunDecisionAlgorithm()
        {
            Console.Clear();
            int[] numbers = ArrayGenerator.GenerateArray();
            string operationType = OperatorType.GetOperatorType();

            GetNumber getNum = new GetNumber();
            int number = getNum.AskForANumber();

            var algorithm = new DecisionAlgorithm(numbers);


            bool result = algorithm.Decision(DecisionPredicates.IsEqualTo(number));
            // bool result = algorithm.Decision(DecisionPredicates.IsGreaterThan(number));

            if (result)
            {
                Console.WriteLine("Benne van");
            }
            else
            {
                Console.WriteLine("nincs benne");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Runs the selection algorithm.
        /// </summary>
        private void RunSelectionAlgorithm()
        {

            int[] numbers = ArrayGenerator.GenerateArray();

            Console.WriteLine(LanguageManager.Instance.GetMessage("AskForANumber"));
            var number = int.Parse(Console.ReadLine());

            var algorithm = new SelectionAlgorithm(numbers);

            Predicate<int> predicate = num => num == number;

            int result = algorithm.Selection(predicate);

            Console.WriteLine($"{LanguageManager.Instance.GetMessage("TheResult")} {result}. indexen van.");
            Console.ReadLine();
        }
        private void RunLinearSearchAlgorithm()
        {

            int[] numbers = ArrayGenerator.GenerateArray();
            GetNumber getNum = new();
            int number = getNum.AskForANumber();
            LinearSearchAlgorithm algorithm = new(numbers);
            Predicate<int> predicate = num => num == number;
            bool result = algorithm.LinearSearch(predicate, out int index);
            if (result)
            {
                Console.WriteLine($"{LanguageManager.Instance.GetMessage("TheResult")} {result}. {index}. indexen van.");
            }
            else
            {
                Console.WriteLine($"{LanguageManager.Instance.GetMessage("TheResult")} {result}. Az elem nem található.");
            }
            Console.ReadLine();
        }
        private void RunCountingAlgorithm()
        {
            int[] numbers = ArrayGenerator.GenerateArray();
            GetNumber getNum = new();
            int number = getNum.AskForANumber();
            CountingAlgorithm algorithm = new(numbers);
            Predicate<int> predicate = num => num == number;
            int result = algorithm.Counting(predicate);
            Console.WriteLine(LanguageManager.Instance.GetMessage("TheResult: "));
            Console.ReadLine();
        }
        private void RunMaximumSelectionAlgorithm()
        {

            int[] numbers = ArrayGenerator.GenerateArray();
            GetNumber getNum = new();
            int number = getNum.AskForANumber();
            MaximumSelectionAlgorithm algorithm = new(numbers);
            // Predicate<int> predicate = num => num == number;
            int result = algorithm.MaximumSelection((a, b) => a < b);
            Console.WriteLine(LanguageManager.Instance.GetMessage("RunMaximumSelectionAlgorithm") + ($"{result}"));

        }
    }
}