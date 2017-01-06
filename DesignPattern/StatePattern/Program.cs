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
            GumballMachine gm = new GumballMachine(5, args[0]);
            Console.WriteLine(gm);

            gm.InsertQuarter();
            gm.TurnCrank();

            GumballMonitor m = new GumballMonitor(gm);

            m.Report();
            Console.ReadKey(true);
        }
    }
}
