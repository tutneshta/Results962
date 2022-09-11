using System;
using System.Collections.Generic;
using System.Text;

namespace Task92
{
    class SortName
    {
        public void NameSortUp(int x)
        {
            Console.WriteLine("Сортировка от А до Я \n");

            Program program = new Program();

            Array.Sort(program.ArrayName);

            foreach (var item in program.ArrayName)
            {
                Console.WriteLine(item);
            }

        }

        public void NameSortDown(int x)
        {
            Console.WriteLine("Сортировка от Я до А \n");

            Program program = new Program();

            Array.Sort(program.ArrayName);

            Array.Reverse(program.ArrayName);

            foreach (var item in program.ArrayName)
            {
                Console.WriteLine(item);
            }

        }
    }
}
