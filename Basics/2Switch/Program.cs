using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Switch";

            string operation;
            double operand1, operand2, answer;
            answer = 0;

            Console.Write("Enter the operation: ");
            operation = Console.ReadLine();

            Console.Write("\nEnter the first operand: ");
            operand1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("\nEnter the second operand: ");
            operand2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case "+": answer = operand1 + operand2; Console.WriteLine("\nYour answer is {0}\n", answer); break;
                case "-": answer = operand1 - operand2; Console.WriteLine("\nYour answer is {0}\n", answer); break;
                case "/": answer = operand1 / operand2; Console.WriteLine("\nYour answer is {0}\n", answer); break;
                case "*": answer = operand1 * operand2; Console.WriteLine("\nYour answer is {0}\n", answer); break;
                default: Console.WriteLine("Error"); break;
            }
        }
    }
}
