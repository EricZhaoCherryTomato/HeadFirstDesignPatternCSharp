using System;
using InteratorPattern.Menu;

namespace InteratorPattern
{
    public class Waitress
    {
        private IMenu dinerMenu;

        private MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
           allMenus.Print();
        }

        private void printMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem) iterator.Next();
                Console.WriteLine(menuItem.GetName());
            }
        }
    }
}