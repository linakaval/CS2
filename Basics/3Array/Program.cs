using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Array";

            int[] array = new int[10];
            int specialNum, specialNumCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("Enter a number: ");
                }
                else
                {
                    Console.Write("Enter another number: ");
                }
                    array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter a special number: ");
            specialNum = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            foreach (var item in array)
            {
                Console.WriteLine(item);

                if (item == specialNum)
                {
                    specialNumCount++;
                }
            }
            Console.WriteLine("Your special number appeared {0} times", specialNumCount);
        }
    }
}
