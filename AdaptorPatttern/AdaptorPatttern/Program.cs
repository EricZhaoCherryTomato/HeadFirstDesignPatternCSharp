using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPatttern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdaptor = new TurkeyAdaptor(turkey);

            Console.WriteLine("Turkey says....");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("Duck says ....");
            testDuck(duck);

            Console.WriteLine("Turkey Adaptor says ...");
            testDuck(turkeyAdaptor);

            Console.ReadKey(true);
        }

        private static void testDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
