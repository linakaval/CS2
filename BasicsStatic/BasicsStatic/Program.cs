using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Jubal = new Student("Jubal", 5);
            Console.WriteLine(Jubal);

            Student Bob = new Student("Bob", 4);
            Console.WriteLine(Bob);

            Student Mary = new Student("Mary", 6);
            Console.WriteLine(Mary);
        }
    }
}
