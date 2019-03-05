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
        int TargetItemID = 0;
        bool IsRunning = true;
        //Ved godt du sagde array men jeg følte at en list var mere praktisk selvom vi ikke har lært om den endnu :)
        LinkedList<MenuItem> MenuItemList = new LinkedList<MenuItem>();

        public Menu(string title)
        {
            MenuTitle = title;
        }

        public void AddMenuItem(string title, string content)
        {
            MenuItemList.AddLast(new MenuItem(title, content));
        }

        public void AddMenuItem(string title, Menu content)
        {
            
        }

        public void Start()
        {
            do
            {
                DrawMenu();
                HandleInput();
            } while (IsRunning);
        }

        /// <summary>
        /// Draw console menu
        /// </summary>
        private void DrawMenu()
        {
            for(int i = 0; i < MenuItemList.Count; i++)
            {
                if (i == TargetItemID)
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine(MenuItemList.ElementAt(i).MenuItemTitle);
                Console.ResetColor();
            }
        }
        private void HandleInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Backspace:
                case ConsoleKey.Escape:
                    IsRunning = false;
                    break;
                case ConsoleKey.DownArrow:
                    if (TargetItemID > 0)
                        TargetItemID = MenuItemList.Count - 1;
                    else
                        TargetItemID++;
                    break;
                case ConsoleKey.UpArrow:
                    if (TargetItemID < MenuItemList.Count - 1)
                        TargetItemID = 0;
                    else
                        TargetItemID--;
                    break;
                case ConsoleKey.Enter:
                    MenuItemList.ElementAt(TargetItemID).Select();
                    TargetItemID = 0;
                    break;
                default:
                    break;
            }
            //System.Threading.Thread.Sleep(200);
            Console.Clear();
        }
    }

    class MenuItem
    {
        public string MenuItemTitle;
        public string MenuItemContent;

        public MenuItem(string title, string content)
        {
            MenuItemTitle = title;
            MenuItemContent = content;
        }

        public void Select()
        {

        }
    }
}
