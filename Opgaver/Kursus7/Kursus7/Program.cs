using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Test = new List<int>();
            Test.Add(5);
            Test.Add(7);
            Test.Add(2);
            Test.Add(9);

            List<string> STest = new List<string>();
            STest.Add("Aleph");
            STest.Add("What");
            STest.Add("Are");
            STest.Add("You");

            Console.WriteLine(HandyMethods.Max<int>(Test));
            Console.WriteLine(HandyMethods.Min<int>(Test));

            Console.WriteLine(HandyMethods.Max<string>(STest));
            Console.WriteLine(HandyMethods.Min<string>(STest));

            Console.ReadKey();
        }
    }

    class HandyMethods
    {
        public static T Max<T>(List<T> list) where T : IComparable<T>
        {
            T Temp = list.Last();
            foreach(T item in list)
            {
                if (item.CompareTo(Temp) > 0)
                {
                    Temp = item;
                }
            }
            return Temp;
        }

        public static T Min<T>(List<T> list) where T : IComparable<T>
        {
            T Temp = list.Last();
            foreach (T item in list)
            {
                if (item.CompareTo(Temp) < 0)
                {
                    Temp = item;
                }
            }
            return Temp;
        }
    }
}
