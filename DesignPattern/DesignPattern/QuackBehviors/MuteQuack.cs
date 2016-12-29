using System;
using DesignPattern.Interfaces;

namespace DesignPattern.QuackBehviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}