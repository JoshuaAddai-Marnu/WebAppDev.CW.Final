using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWeb.Models
{
    public class Product
    {
        public int ProductId { get; set; } 
        public string Name { get; set; } 
        public string? Description { get; set; } 
        public decimal Price { get; set; } 
        public int? StockQuantity { get; set; } 
        public DateTime? CreatedAt { get; set; } 
        

         // Property for storing product image as binary data
        public byte[]? ImageData { get; set; }
        public string? ImageMimeType { get; set; }
         
         // Navigation property for Suppliers
        public List<Supplier>? Suppliers { get; set; }
        
        // Navigation property for Categories
        public List<Category>? Categories { get; set; }
    }
}