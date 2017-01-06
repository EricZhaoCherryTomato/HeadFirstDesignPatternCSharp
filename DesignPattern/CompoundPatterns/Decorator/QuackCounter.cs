namespace CompoundPatterns.Decorator
{
    public class QuackCounter : IQuackable
    {
        private IQuackable _duck;
        private static int numbeOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            numbeOfQuacks++;
        }

        public static int GetQuacks()
        {
            return numbeOfQuacks;
        }
    }
}