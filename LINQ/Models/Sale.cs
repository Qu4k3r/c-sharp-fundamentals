using System;

namespace LINQ.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
} 