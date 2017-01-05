namespace InteratorPattern.Menu
{
    public class MenuItem
    {
        private string _description;
        private string _name;
        private double _price;
        private bool _vegetarian;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }
    }
}