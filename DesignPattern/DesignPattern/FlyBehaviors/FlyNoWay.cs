using System;
using DesignPattern.Interfaces;

namespace DesignPattern.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly!");
        }
    }
}