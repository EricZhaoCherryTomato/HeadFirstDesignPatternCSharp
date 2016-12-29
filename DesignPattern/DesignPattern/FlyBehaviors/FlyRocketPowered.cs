using System;
using DesignPattern.Interfaces;

namespace DesignPattern.FlyBehaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket!");
       }  
    }
}