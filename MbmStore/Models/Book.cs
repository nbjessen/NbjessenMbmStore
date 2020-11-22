using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        //Fields
        //Properties
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }
        public string ImageFileName { get; set;}


        //Constructor
        public Book() 
        {

        }
        public Book(int productID, string title, decimal price, string author, short published, string publisher, string isbn, string imagefilename): base(productID, title, price)
        {
            Author = author;
            Published = published;
            Publisher = publisher;
            ISBN = isbn;
            ImageFileName = imagefilename;
        }
    }
}
