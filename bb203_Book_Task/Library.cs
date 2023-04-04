using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb203_Book_Task
{
    internal class Library
    {
       public Book[] Books=new Book[0];

      

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        }
    }
}
