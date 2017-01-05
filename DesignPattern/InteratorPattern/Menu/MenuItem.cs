using System;

namespace InteratorPattern.Menu
{
    public class MenuItem : MenuComponent
    {
        private string _description;
        private readonly string _name;
        private double _price;
        private bool _vegetarian;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override void Print()
        {
            Console.WriteLine(GetName());
        }
    }
}