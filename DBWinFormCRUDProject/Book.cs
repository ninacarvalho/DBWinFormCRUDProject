using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWinFormCRUDProject
{
    public class Book
    {
        public int ISBN { get; set; }
        public String Title { get; set; }

        public String Author { get; set; }
        public double Price { get; set; }

        public Book(int iSBM, string title, string author, double price)
        {
            ISBN = iSBM;
            Title = title;
            Author = author;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Book ISBN is {this.ISBN}  Title is {this.Title} ,....";
        }
    }
}
