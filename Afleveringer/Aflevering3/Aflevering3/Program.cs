using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aflevering3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu Submenu = new Menu("Test");
            Submenu.AddMenuItem("Submenu option 1", "Content contained in submenu");
            Submenu.AddMenuItem("Submenu option 2", "......");

            Menu test = new Menu("Test");
            test.AddMenuItem("Click", "Content");
            test.AddMenuItem("Click2", "Content");
            test.AddMenuItem("Click3", Submenu);


            test.Start();
        }
    }
}
