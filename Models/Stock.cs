namespace PosApp.Models
{
    public class Stock
    {
        public string Sku { get; set; } = string.Empty;
        public int Quantity { get; set; }

        // Navigation property
        public Product Product { get; set; } = null!;
    }
}
