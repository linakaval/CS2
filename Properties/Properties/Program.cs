using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Account savings = new Account(1, 10000000000.72);
            Account savings2 = new Account(2, -2.4);

            //Part 2
            Console.WriteLine("Savings1 account #: {0}", savings.AccountNumber);
            Console.WriteLine("Savings1 account balance: {0}", savings.AccountBalance);

            //Part 3
            Console.WriteLine("Is Savings1 account overdrawn? {0}", savings.IsOverdrawn);
            Console.WriteLine("Is Savings2 account overdrawn? {0}", savings2.IsOverdrawn);

            //Part 4
            savings.InterestEarned = 3;
            Console.WriteLine("Interest earned by Savings1: {0}", savings.InterestEarned);

            savings2.InterestEarned = -3;
            Console.WriteLine("Interest earned by Savings2: {0}", savings2.InterestEarned);


            //Part 5
            Account.InterestRate = .07;
            Console.WriteLine("Interest rate of accounts: {0}", Account.InterestRate);

            Account.InterestRate = -.04;
            Console.WriteLine("Interest rate of accounts: {0}", Account.InterestRate);

        }
    }
}
