using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWeb.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; } 
        //public int OrderId { get; set; } // Identifier for the order this item belongs to
        public string ProductName { get; set; } 
        public decimal UnitPrice { get; set; } // Price per unit of the product
        public int Quantity { get; set; } // Quantity of the product in this order item
        public decimal TotalPrice { get { return UnitPrice * Quantity; } } // Total price for this order item (calculated based on unit price and quantity)
        
         // Foreign key for Product
        public int ProductId { get; set; }
        // Navigation property for Product
        public Product? Product { get; set; }
    }
}