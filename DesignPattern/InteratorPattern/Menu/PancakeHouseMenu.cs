using System.Collections;

namespace InteratorPattern.Menu
{
    public class PancakeHouseMenu
    {
        public readonly ArrayList MenuItems;

        public PancakeHouseMenu()
        {
            MenuItems = new ArrayList();
            AddItem("K&B's Pancake Breakfast",
                    "Pancakes with scrambled eggs, and toast",
                    true,
                    2.99);
            AddItem("Regular Pancake Breakfast",
                    "Pancakes regular",
                    true,
                    3.49);
            AddItem("BuleBerry Pancake Breakfast",
                    "Pancakes with BlueBerry",
                    true,
                    3.59);
            AddItem("Waffles",
                    "Waffles",
                    true,
                    3.68);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem);
        }

        public ArrayList GetMenuItems()
        {
            return MenuItems;
        }

    }
}