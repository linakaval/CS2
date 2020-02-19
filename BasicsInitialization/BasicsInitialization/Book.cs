using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsInitialization
{
    class Book
    {
        private string myTitle;
        private string myAuthor;
        private bool available;

        public Book(string aTitle, string aAuthor, bool availability)
        {
            myTitle = aTitle;
            myAuthor = aAuthor;
            available = availability;
        }

        public Book(string aTitle)
            :this(aTitle, "anonymous", true)
        {

        }

        public Book(string aTitle, string aAuthor)
            :this(aTitle, aAuthor, true)
        {

        }

        public Book()
            :this("untitled", "anonymous", true)
        {

        }

        public override string ToString()
        {
            return myTitle + "   " + myAuthor + "   " + available;
        }


    }
}
