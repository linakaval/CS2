using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TestingStuff
    {
        public bool hasAVowel(string word)
        {
            foreach (var item in word.ToUpper())
            {
                if ("AEIOU".Contains(item))
                {
                    return true;
                }
                //else return false;
            }
            return false;
        }
    }
}
