using System;

namespace InteratorPattern
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}