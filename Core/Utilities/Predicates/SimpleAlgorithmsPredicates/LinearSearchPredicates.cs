namespace AlgoForge.Core.Predicates
{
    public static class LinearSearchPredicates
    {
        // Keres�s egy �rt�kre
        public static Predicate<int> IsEqualTo(int value) => num => num == value;

        // Keres�s nagyobb �rt�kekre
        public static Predicate<int> IsGreaterThan(int value) => num => num > value;
    }
}
