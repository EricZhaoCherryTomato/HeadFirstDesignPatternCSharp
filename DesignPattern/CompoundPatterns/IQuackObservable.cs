using System;

namespace CompoundPatterns
{
    public interface IQuackObservable
    {
        void RegisterObserver<T>(IObserver<T> observer);
        void NotifyObservers();
    }
}