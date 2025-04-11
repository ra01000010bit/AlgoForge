namespace AlgoForge.Core.Predicates
{
    public static class SelectionPredicates
    {
        // Kiválasztja a legkisebb számot
        public static Func<int, int, bool> IsSmaller = (x, y) => x < y;

        // Kiválasztja a legnagyobb számot
        public static Func<int, int, bool> IsLarger = (x, y) => x > y;
    }
}
