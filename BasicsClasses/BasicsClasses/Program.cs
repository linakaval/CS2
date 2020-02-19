using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Basic Classes";
            ParameterTest p = new ParameterTest();

            //testing Value method
            Console.WriteLine("Test for Value method.");
            int testing;
            Console.Write("Enter a number: ");
            testing = Convert.ToInt16(Console.ReadLine());
            p.Value(testing);
            Console.WriteLine(testing);

            //testing Swap method
            Console.WriteLine("\nTest for Swap method.");
            Console.Write("Enter the first number: ");
            int testing2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int testing3 = Convert.ToInt16(Console.ReadLine());
            p.Swap(ref testing2, ref testing3);
            Console.WriteLine("The new order of the numbers: {0}, {1}", testing2, testing3);

            //testing OddEven method
            Console.WriteLine("\nTest for OddEven method.");
            int[] testArray = { 4, 5, 6, 7, 8, 9, 8, 8, 8 };
            int testingX, testingY;
            p.OddEven(testArray, out testingX, out testingY);
            Console.WriteLine(testingX);
            Console.WriteLine(testingY);

            VariableLengthParamList v = new VariableLengthParamList();

            //testing Sum method
            Console.WriteLine("\nTest for Sum method.");
            Console.WriteLine(v.Sum("data"));
            Console.WriteLine(v.Sum("data", 1));
            Console.WriteLine(v.Sum("data", 1, 2, 3));
            Console.WriteLine(v.Sum("data", new int[] { 1, 2, 3, 4 }));
        }
}
}