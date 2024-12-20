using System;
using System.Collections.Generic;
using System.Linq;
using testSoftServe;
class Program
{
     static void Main(string[] args)
     {
        Library library=new Library();
        foreach(Book book in library) { Console.WriteLine($"{book.Name},{book.InHome,20},{book.Author,20}"); }
    }
}
