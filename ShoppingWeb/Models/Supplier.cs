using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWeb.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; } 
        public string Name { get; set; } 
        public string? ContactName { get; set; } 
        public string? ContactEmail { get; set; } 
        public string? Phone { get; set; } 
        public string? Address { get; set; } 


         // Navigation property for Products
        public List<Product>? Products { get; set; }
    }
}