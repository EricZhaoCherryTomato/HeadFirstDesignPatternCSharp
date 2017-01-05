using System;

namespace InteratorPattern.Menu
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw  new NotImplementedException();
        }

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }

        public virtual string GetDescription()
        {
            throw new NotImplementedException();
        }

        public double GetPrice()
        {
            throw new NotImplementedException();
        }

        public bool IsVegetarin()
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }
}