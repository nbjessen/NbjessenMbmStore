﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem
    {
        //Properties
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; }
        //Constructor
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

    }
}
