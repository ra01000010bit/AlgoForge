namespace AlgoForge.Core.Predicates
{
    public static class SelectionPredicates
    {
        // Kiv�lasztja a legkisebb sz�mot
        public static Func<int, int, bool> IsSmaller = (x, y) => x < y;

        // Kiv�lasztja a legnagyobb sz�mot
        public static Func<int, int, bool> IsLarger = (x, y) => x > y;
    }
}
