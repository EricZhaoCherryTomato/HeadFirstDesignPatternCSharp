using System;
using DesignPattern.Interfaces;

namespace DesignPattern.QuackBehviors
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Normal Quack!");
        }
    }
}