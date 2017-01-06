using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.State;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gm = new GumballMachine(5);
            Console.WriteLine(gm);

            gm.InsertQuarter();
            gm.TurnCrank();

            Console.ReadKey(true);
        }
    }
}
