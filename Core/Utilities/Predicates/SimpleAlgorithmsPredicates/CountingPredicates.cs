namespace AlgoForge.Core.Predicates
{
    public static class CountingPredicates
    {
        // Megszámolja, hány alkalommal szerepel egy adott szám
        public static Predicate<int> IsEqualTo(int value) => num => num == value;

        // Megszámolja, hány páros szám van
        public static Predicate<int> IsEven => num => num % 2 == 0;

        // Megszámolja, hány szám nagyobb, mint egy adott érték
        public static Predicate<int> GreaterThan(int value) => num => num > value;
    }
}
