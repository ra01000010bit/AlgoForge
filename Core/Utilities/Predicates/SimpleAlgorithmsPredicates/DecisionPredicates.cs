namespace AlgoForge.Core.Utilities.Predicates.SimpleAlgorithmsPredicates
{
    public static class DecisionPredicates
    {
        // Elem keres�se egy t�mbben
        public static Predicate<int> IsEqualTo(int value) => num => num == value;

        // Elem keres�se egy t�mbben (nagyobb mint a keresett �rt�k)
        public static Predicate<int> IsGreaterThan(int value) => num => num > value;
    }
}
