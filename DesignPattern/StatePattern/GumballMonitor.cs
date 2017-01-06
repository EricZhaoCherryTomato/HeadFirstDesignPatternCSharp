using System;
using StatePattern.State;

namespace StatePattern
{
    public class GumballMonitor
    {
        private GumballMachine _machine;

        public GumballMonitor(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Report()
        {
            Console.WriteLine(_machine.GetLocation());
            Console.WriteLine(_machine.GetCount());
            Console.WriteLine(_machine.GetState());
        }
    }
}