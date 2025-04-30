namespace LINQ.DTO
{
    // Classes DTO para retorno de dados
    public class ExpensiveBookDTO
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }

    public class AuthorDTO
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class LowStockBookDTO
    {
        public string Title { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
    }

    public class RecentSaleDTO
    {
        public string Title { get; set; }
        public DateTime SaleDate { get; set; }
        public int Quantity { get; set; }
    }
}