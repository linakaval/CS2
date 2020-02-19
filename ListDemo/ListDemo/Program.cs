using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(500); //you declare variables, but construct methods

            names.Add("Jubal");
            names.Add("Alice");
            names.Add("Billy Bob");
            names.Add("Jubal");
            names.Add("Alice");
            names.Add("Billy Bob");
            names.Add("Jubal");
            names.Add("Alice");
            names.Add("Billy Bob");

            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(names[i]); //index operator
            //}

            foreach (var item in names)
            {
                Console.WriteLine(item); //helps get rid of off-by-1 errors
            }

            Console.WriteLine("\nNumber of names = " + names.Count);
            Console.WriteLine("Capacity of the list = " + names.Capacity);
            Console.WriteLine("The 3rd item = " + names[2]);
            Console.WriteLine("The last item = " + names.Last());
        }
    }
}
