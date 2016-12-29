using System;
using DesignPattern.AbstractClasses;
using DesignPattern.FlyBehaviors;
using DesignPattern.QuackBehviors;

namespace DesignPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new NormalQuack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}