using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompoundPatterns.Composite;
using CompoundPatterns.Decorator;
using CompoundPatterns.Factory;

namespace CompoundPatterns
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            simulator.Simulate(duckFactory);

            Console.ReadKey(true);
        }

        private void Simulate(AbstractDuckFactory duckFactory)
        {
            //IQuackable mallardDuck = new MallardDuck();
            //IQuackable readheadDuck = new RedheadDuck();
            //IQuackable duckCall = new DuckCall();
            //IQuackable rubberDuck = new RubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable readheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(readheadDuck);
            flockOfDucks.Add(duckCall);

            Simulate(flockOfDucks);
          

            Console.WriteLine("The ducks quacked: "+ QuackCounter.GetQuacks());
            
        }

        private void Simulate(IQuackable duck)
        {
           duck.Quack();
        }
    }
}
