using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.greeting(2);
            p.greeting(3, "Howdy");
            p.goodbye();
            p.goodbye(what:"so long");
        }
    }
    class Person
    {
        public void greeting(int times, string what = "Hello") //pseudo-overloading by giving default value in param list
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(what);
            }
        }

        public void goodbye(int times = 1, string what = "bye-bye") //this method has 2 optional parameters
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(what);
            }
        }
    }
}
