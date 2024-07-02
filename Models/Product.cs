namespace D_MartApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }

        public bool IsExpired { get; set; }

    }
}
