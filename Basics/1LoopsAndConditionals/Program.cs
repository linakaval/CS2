using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1LoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Loops and Conditionals";

            int i = 0;
            double pi = 0;

            while (i < 1000)
            {
                if (i % 2 == 0)
                {
                    pi += 4 * (1.0 / (2 * i + 1));
                }
                else if (i % 2 == 1)
                {
                    pi -= 4 * (1.0 / (2 * i + 1));
                }
                i++;
            }
            Console.WriteLine(pi);
        }
    }
}
