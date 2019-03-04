using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aflevering3
{
    class Menu
    {
        string MenuTitle { get; }
        //Ved godt du sagde array men jeg følte at en list var mere praktisk selvom vi ikke har lært om den endnu :)
        LinkedList<MenuItem> MenuItemList = new LinkedList<MenuItem>();

        public Menu(string title)
        {
            MenuTitle = title;
        }

        public void AddMenuItem(string title, Action action)
        {
            MenuItemList.AddLast(new MenuItem(title, action));
        }
    }

    class MenuItem
    {
        string MenuItemTitle { get; }
        public Action ActionToPerform;

        public MenuItem(string title, Action action)
        {
            MenuItemTitle = title;
            ActionToPerform = action;
        }
    }
}
