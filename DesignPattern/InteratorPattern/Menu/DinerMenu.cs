using System;

namespace InteratorPattern.Menu
{
    public class DinerMenu
    {
        public static readonly int MaxItems = 6;
        private int _numberOfItems;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MaxItems];
            AddItem("Dinner BLT",
                    "Dinner",
                    true,
                    2.99);
            AddItem("BLT",
                    "BLT ...",
                    false,
                    3.49);
            AddItem("Soup of the day",
                    "Soup of the day",
                    false,
                    4.99);
            AddItem("Hotdog",
                    "Hotdog",
                    false,
                    3.05);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MaxItems)
            {
                Console.Error.WriteLine("Sorry, menu is full!");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public IIterator CreaIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}