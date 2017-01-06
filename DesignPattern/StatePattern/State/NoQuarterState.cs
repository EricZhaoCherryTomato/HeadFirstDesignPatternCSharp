using System;

namespace StatePattern.State
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
           Console.WriteLine("You truned, but there is no quarter.");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}