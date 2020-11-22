using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields
        private decimal price;
        // properties
        public string Director { get; set; }

        /*public string Title { 
            get  return Title; }
            set { Title = value; }
        }*/

        public string ImageFileName {
            get; 
            set;
        }

        public new decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }

        // constructors
        public Movie() { }

        public Movie(int productID, string title, decimal price): base (productID, title, price)
        {
        }

        public Movie(int productID, string title, decimal price, string imageFileName, string director): base (productID, title, price)
        {
            Price = price;
            ImageFileName = imageFileName;
            Director = director;
        }
    }
}