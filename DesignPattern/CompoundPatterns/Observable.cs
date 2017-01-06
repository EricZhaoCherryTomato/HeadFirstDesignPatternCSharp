using System;
using System.Collections;

namespace CompoundPatterns
{
    public class Observable : IQuackObservable
    {
        private ArrayList observers = new ArrayList();
        private IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver<T>(IObserver<T> observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver<Type> observer in observers)
            {
                observer.
            }
        }
    }
}