using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Account
    {
        private int myAccountNum;
        private double myAccountBalance;
        private double myAccountInterest;
        private static double myInterestRate;

        public int AccountNumber
        {
            get
            {
                return myAccountNum;
            }
        }

        public double AccountBalance
        {
            get
            {
                return myAccountBalance;
            }
        }
        
        public bool IsOverdrawn
        {
            get
            {
                return myAccountBalance < 0;
            }
        }

        public double InterestEarned
        {
            get
            {
                return myAccountInterest;
            }
            set
            {
                if (value < 0)
                {
                    //error
                    Console.WriteLine("Error: Cannot have negative input. Input: {0}", value);
                    return;
                }
                else
                {
                    myAccountInterest = value;
                }
            }
        }

        public static double InterestRate
        {
            get
            {
                return myInterestRate;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Cannot have negative input. Input: {0}", value);
                    return; 
                }
                else
                {
                    myInterestRate = value;
                }
            }
        }

        public Account(int aAccountNum, double aAccountBalance)
        {
            myAccountNum = aAccountNum;
            myAccountBalance = aAccountBalance;
        }
    }
}
