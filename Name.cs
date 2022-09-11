using System;
using System.Collections.Generic;
using System.Text;

namespace Task92
{
    class Name
    {
        public delegate void MethodSortr(int x);

        public event MethodSortr OnSortrUp;

        public event MethodSortr OnSortrDown;

        public void NameSort(int x)
        {

            if (x == 1)
            {
                OnSortrUp(x);
            }
            if (x == 2)
            {
                OnSortrDown(x);
            }

        }
    }
}
