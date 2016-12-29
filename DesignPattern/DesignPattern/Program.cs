using System;
using DesignPattern.AbstractClasses;
using DesignPattern.FlyBehaviors;

//Design Principal: 1. Identify the aspects of your application that vary and separate them from what stays the same.
//2. Program to an interface, not an implementation. 

namespace DesignPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //The startegy pattern: defines a family of algorithms, encapsulates each one, and makes them interchangeable.
            //Strategy lets the algorithm vary independently from clients that use it.
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck modelDuck = new ModelDuck();
            modelDuck.PerformQuack();
            modelDuck.PerformFly();

            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();
            Console.ReadLine();
        }
    }
}