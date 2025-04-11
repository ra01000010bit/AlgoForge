namespace AlgoForge.Core.Predicates
{
    public static class SummationPredicates
    {
        public static Func<int, int, int> Addition = (x, y) => x + y;

        public static Func<int, int, int> Subtraction = (x, y) => x - y;

        public static Func<int, int, int> Multiplication = (x, y) => x * y;
    }
}
