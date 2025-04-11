namespace AlgoForge.Core.Utilities.Predicates.SimpleAlgorithmsPredicates
{
    public static class DecisionPredicates
    {
        // Elem keresése egy tömbben
        public static Predicate<int> IsEqualTo(int value) => num => num == value;

        // Elem keresése egy tömbben (nagyobb mint a keresett érték)
        public static Predicate<int> IsGreaterThan(int value) => num => num > value;
    }
}
