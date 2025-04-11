namespace AlgoForge.Core.Predicates
{
    public static class MaxSelectionPredicates
    {
        // Kiválasztja a legnagyobb számot
        public static Func<int, int, bool> IsGreaterThan = (x, y) => x > y;
    }
}
