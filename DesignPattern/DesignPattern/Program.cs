using System;

//Design Principal: 1. Identify the aspects of your application that vary and separate them from what stays the same.
//2. Program to an interface, not an implementation. 

namespace DesignPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.ReadLine();
        }
    }

    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All duck float, even dcoys!");
        }
    }

    public interface IQuackBehavior
    {
        void Quack();
    }

    public interface IFlyBehavior
    {
        void Fly();
    }

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

    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Normal Quack!");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly!");
        }
    }
}