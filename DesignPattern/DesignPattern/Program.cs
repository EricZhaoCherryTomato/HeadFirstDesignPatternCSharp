using System;
using DesignPattern.AbstractClasses;

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
}