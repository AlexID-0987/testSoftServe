using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSoftServe
{
    internal class Library:IEnumerable
    {
        readonly public List<Book> books = new List<Book>
        {
            new Book("Narnia",true,"Luis"),
            new Book("C#",true,"Stiven"),
            new Book("JS",true,"Roal"),
            new Book("Java",false,"Bred"),
        };

        public IEnumerator GetEnumerator() => new InTheHoomeBooks(books);
        
        
    }
}
