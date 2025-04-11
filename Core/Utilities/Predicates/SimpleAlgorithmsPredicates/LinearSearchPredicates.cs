namespace AlgoForge.Core.Predicates
{
    public static class LinearSearchPredicates
    {
        // Keresés egy értékre
        public static Predicate<int> IsEqualTo(int value) => num => num == value;

        // Keresés nagyobb értékekre
        public static Predicate<int> IsGreaterThan(int value) => num => num > value;
    }
}
