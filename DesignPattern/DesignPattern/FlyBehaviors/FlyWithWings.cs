using System;
using DesignPattern.Interfaces;

namespace DesignPattern.FlyBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
}