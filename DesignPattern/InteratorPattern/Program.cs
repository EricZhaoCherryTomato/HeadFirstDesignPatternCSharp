using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using InteratorPattern.Menu;

namespace InteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent dm = new Menu.Menu("Dinner Menu", "Lunch");

            MenuComponent allMenu = new Menu.Menu("all menus","all combined");
            allMenu.Add(dm);
            dm.Add(new MenuItem("Pasta","Spaghetti",true,3.89));
            Waitress w = new Waitress(allMenu);
            w.printMenu();
            Console.ReadKey(true);
        }
    }
}
