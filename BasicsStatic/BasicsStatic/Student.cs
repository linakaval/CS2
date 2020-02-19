using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsStatic
{
    class Student
    {
        private string myName;
        private int myAge;
        private int myID;
        private static int nextID;


        static Student()
        {
            nextID = 1;

            
        }

        public Student(string aName, int aAge)
        {
            myName = aName;
            myAge = aAge;
            myID = nextID;
            nextID++;
        }
        
        public override string ToString()
        {
            return "Name: " + myName + " Age: " + myAge + " ID: "+ myID;
        }
    }
}
