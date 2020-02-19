using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 Testing
            Book b = new Book("The BFG", "Roald Dahl", false);
            Console.WriteLine(b.ToString());

            //Part 2 Testing
            Console.WriteLine(new Book("My Life", "Jubal", false));
            Console.WriteLine(new Book("My Life", "Jubal"));
            Console.WriteLine(new Book("My Life"));
            Console.WriteLine(new Book());

        }
    }
}
