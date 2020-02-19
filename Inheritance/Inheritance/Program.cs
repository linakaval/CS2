using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inheritance";

            Stock ms = new Stock("Microsoft", 8000, 1994, "MSFT", 200, 56);
            Building bh = new Building("Beach House", 9000, 1964, 35000, "123 Seashore Ave, Malibu, CA");
            Art nh = new Art("Nighthawks", 850, 1955, 7500, "Edward Hopper", 1942);

            Console.WriteLine("\nAmortized costs per year:");
            Console.WriteLine("Microsoft stock ${0}", ms.amortizedCost(2002));
            Console.WriteLine("Beach house ${0}", bh.amortizedCost(2002));
            Console.WriteLine("Nighthawks ${0}", nh.amortizedCost(2002));

            Console.WriteLine("\nValuations:");
            Console.WriteLine("Microsoft stock ${0}", ms.computeValue());
            Console.WriteLine("Beach house ${0}", bh.computeValue());
            Console.WriteLine("Nighthawks ${0}", nh.computeValue());

            Console.WriteLine();
            ms.print(); Console.WriteLine();
            bh.print(); Console.WriteLine();
            nh.print(); Console.WriteLine();
        }
    }

    class Asset
    {
        private string myName;
        private double myCost;
        private int yearPurchased;

        public Asset(string aName, double aCost, int aYearPurchased)
        {
            myName = aName;
            myCost = aCost;
            yearPurchased = aYearPurchased;
        }

        public double amortizedCost(int currentYear)
        {
            return myCost / (currentYear - yearPurchased);
        }

        public double computeValue()
        {
            return myCost;
        }

        public void print()
        {
            Console.WriteLine("Name: {0}\nCost: {1}\nPurchase Date: {2}", myName, myCost, yearPurchased);
        }
    }

    class Stock : Asset
    {
        private string myTicker;
        private int myNumberOfShares;
        private double mySharePrice;

        public Stock(string aName, double aCost, int aYear, string aTicker, int aNumberOfShares, int aSharePrice)
        :base(aName, aCost, aYear)
        {
            myTicker = aTicker;
            myNumberOfShares = aNumberOfShares;
            mySharePrice = aSharePrice;
        }

        public new double computeValue()
        {
            return myNumberOfShares * mySharePrice;
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("Symbol: {0}\nShares: {1}\nPrice: {2}", myTicker, myNumberOfShares, mySharePrice);
        }
    }

    class Property : Asset
    {
        private double myAssessedValue;

        public Property(string aName, double aCost, int aYear, double anAssessedValue)
        :base(aName, aCost, aYear)
        {
            myAssessedValue = anAssessedValue;
        }

        public new double computeValue()
        {
            return myAssessedValue;
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("Assessment: {0}", myAssessedValue);
        }
    }

    class Building : Property
    {
        private string myAddress;

        public Building(string aName, double aCost, int aYear, double anAssessedValue, string anAddress)
        :base(aName, aCost, aYear, anAssessedValue)
        {
            myAddress = anAddress;
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("Address: {0}", myAddress);
        }
    }

    class Art : Building
    {
        private string myArtistName;
        private int myArtYear;

        public Art(string aName, double aCost, int aYear, double anAssessedValue, string anArtistName, int anArtYear)
        :base(aName, aCost, aYear, anAssessedValue, "")
        {
            myArtistName = anArtistName;
            myArtYear = anArtYear;
            
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("Artist: {0}\nYear Created: {1}", myArtistName, myArtYear);
        }
    }
}
