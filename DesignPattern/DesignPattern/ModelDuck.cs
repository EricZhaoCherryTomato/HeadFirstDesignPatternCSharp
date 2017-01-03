using System;
using DesignPattern.AbstractClasses;
using DesignPattern.FlyBehaviors;
using DesignPattern.QuackBehviors;

namespace DesignPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            QuackBehavior = new NormalQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}