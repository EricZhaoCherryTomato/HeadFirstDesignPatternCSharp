using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteratorPattern.Menu;

namespace InteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DinerMenu dm = new DinerMenu();
            Waitress w = new Waitress(dm);
            w.printMenu();
            Console.ReadKey(true);
        }
    }
}
