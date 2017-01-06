using System;

namespace StatePattern.State
{
    public class GumballMachine
    {
        private static IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;

        private IState _state = _soldOutState;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _soldState = new SoldState(this);
            _hasQuarterState = new HasQuarterState(this);
            _noQuarterState = new NoQuarterState(this);
            _count = numberGumballs;
            if (numberGumballs>0)
            {
                _state = _noQuarterState;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot....");
            if (_count != 0)
            {
                _count--;
            }
        }
        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public int GetCount()
        {
            return _count;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }
    }
}