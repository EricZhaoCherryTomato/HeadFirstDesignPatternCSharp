using System;
using DesignPattern.Interfaces;

namespace DesignPattern.QuackBehviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}