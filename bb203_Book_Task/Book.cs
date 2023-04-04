using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb203_Book_Task
{
    internal class Book:Product
    {
        public string Janr;

        public Book(string janr, string no, string name, double price, int count):base(no,
            name,price,count)
        {
            Janr = janr;
        }
    }
}
