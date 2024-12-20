using System;

namespace uppfinnaren_1_0_seb_kvist.Models
{
    public class Product
    {
        public int ProductId { get; set; } 
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public string? ImagePath { get; set; } 
    }
}