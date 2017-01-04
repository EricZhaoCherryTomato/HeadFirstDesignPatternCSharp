using System;
using System.IO;

namespace TemplatePattern
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffeee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Surger and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            String anser = GetUserInput();
            if (anser.ToLower().StartsWith("y"))
            {
                return true;
            }
            return false;
        }

        private static string GetUserInput()
        {
            string a = null;
            Console.WriteLine("Would you like milk and tea?");
            a = Console.ReadLine();
            return a;
        }
    }
}