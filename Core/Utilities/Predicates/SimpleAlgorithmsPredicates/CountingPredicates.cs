namespace AlgoForge.Core.Predicates
{
    public static class CountingPredicates
    {
        // Megsz�molja, h�ny alkalommal szerepel egy adott sz�m
        public static Predicate<int> IsEqualTo(int value) => num => num == value;

        // Megsz�molja, h�ny p�ros sz�m van
        public static Predicate<int> IsEven => num => num % 2 == 0;

        // Megsz�molja, h�ny sz�m nagyobb, mint egy adott �rt�k
        public static Predicate<int> GreaterThan(int value) => num => num > value;
    }
}
