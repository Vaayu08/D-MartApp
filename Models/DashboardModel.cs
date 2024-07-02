namespace D_MartApp.Models
{
    public class DashboardModel
    {
        public List<ProductSaleData>? MonthlySales { get; set; }
        public List<ProductSaleData>? TrendingProducts { get; set; }
        public List<ProductSaleData>? DailySales { get; set; }
    }
    public class ProductSaleData
    {
        public string? ProductName { get; set; }
        public int QuantitySold { get; set; }
    }

}
