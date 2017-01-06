using System;

namespace StatePattern.State
{
    internal class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't inserted another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _gumballMachine.SetState(_gumballMachine.GetSoldState());
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}