using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        //Fields
        //Properties
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }
        public string Category { get; set; }

        //Constructor
        public Product() 
        {

        }
        public Product (int productID, string title, decimal price) 
        {
            ProductID = productID;
            Title = title;
            Price = price;
        }
    }
}
