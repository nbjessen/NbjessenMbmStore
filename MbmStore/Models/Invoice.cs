using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        //Fields
        //Properties
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice {
            get
            {
                decimal totalPrice = 0;
                foreach (var orderItem in OrderItems)
                {
                    totalPrice += orderItem.Product.Price;
                }
                return totalPrice;
            }
        }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();


        //Constructor
        public Invoice (int invoiceid, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceid;
            OrderDate = orderDate;
            Customer = customer;
        }
        //Method
        public void AddOrderItem(Product product, int quantity)
        {
            var orderItem = new OrderItem(product, quantity);
            OrderItems.Add(orderItem);
        }

       
    }   
}
