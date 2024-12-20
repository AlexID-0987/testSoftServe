using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSoftServe
{
    internal class Book
    {
        public string Name { get; set; }
        public bool InHome { get; set; }
        public string Author { get; set; }
        public Book(string name, bool inHome, string author)
        {
            Name = name;
            InHome = inHome;
            Author = author;
        }

        
    }
}
