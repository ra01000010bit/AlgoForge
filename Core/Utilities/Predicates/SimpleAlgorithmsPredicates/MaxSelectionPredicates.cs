namespace AlgoForge.Core.Predicates
{
    public static class MaxSelectionPredicates
    {
        // Kiv�lasztja a legnagyobb sz�mot
        public static Func<int, int, bool> IsGreaterThan = (x, y) => x > y;
    }
}
