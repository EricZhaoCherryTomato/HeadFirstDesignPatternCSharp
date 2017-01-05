using System;
using InteratorPattern.Menu;

namespace InteratorPattern
{
    public class Waitress
    {
        private DinerMenu dinerMenu;

        public Waitress(DinerMenu dinerMenu)
        {
            this.dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            IIterator dinIterator = dinerMenu.CreaIterator();
            printMenu(dinIterator);
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