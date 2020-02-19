using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsClasses
{
    class ParameterTest
    {

        public void Value(int number)
        {
            number = 42;
        }

        public void Swap(ref int x, ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
        }

        public void OddEven(int[] a, out int x, out int y)
        {
            x = 0;
            y = 0;

            foreach (var item in a)
            {
                if (item % 2 == 0)
                {
                    x++;
                }
                else
                {
                    y++;
                }
            }
        }
    }
}
