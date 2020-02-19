using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Multidimensional Array";

            double[,] a = new double[2, 5];
            Random rand = new Random();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.NextDouble();
                }
            }

            Console.WriteLine("The length is {0}", a.Length);
            Console.WriteLine("The number of rows is {0}", a.GetLength(0));
            Console.WriteLine("The number of elements in each row is {0}", a.GetLength(1));

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
