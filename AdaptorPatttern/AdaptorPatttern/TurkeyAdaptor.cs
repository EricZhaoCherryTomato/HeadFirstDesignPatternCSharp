namespace AdaptorPatttern
{
    public class TurkeyAdaptor : IDuck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdaptor(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
           _turkey.Gobble();
        }

        public void Fly()
        {
           _turkey.Fly();
        }
    }
}