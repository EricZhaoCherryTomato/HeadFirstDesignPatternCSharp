using System;
using System.Collections;

namespace CompoundPatterns.Composite
{
    public class Flock : IQuackable
    {
        private readonly ArrayList _quackers = new ArrayList();

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            foreach (IQuackable quacker in _quackers)
            {
                quacker.Quack();
            }
        }

        public void RegisterObserver<T>(IObserver<T> observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }
    }
}