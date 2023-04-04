using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb203_Book_Task
{
    internal class Product
    {
        public string No;
        public string Name;
        public double Price;
        public int Count;

        public Product(string no,string name,double price,int count)
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
