using D_MartApp.Data;
using D_MartApp.Models;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace D_MartApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly DMartContext _context;

        public HomeController(DMartContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            var Models = new DashboardModel
            {
                MonthlySales = GetMonthlySalesData(),
                TrendingProducts = GetTrendingProductsData(),
                DailySales = GetDailySalesData()
            };
            return View(Models);
        }

        private List<ProductSaleData> GetMonthlySalesData()
        {
            // Fetch and return monthly sales data
            // Example data:
            return new List<ProductSaleData>
        {
            new ProductSaleData { ProductName = "Product1", QuantitySold = 100 },
            new ProductSaleData { ProductName = "Product2", QuantitySold = 200 }
        };
        }

        private List<ProductSaleData> GetTrendingProductsData()
        {
            // Fetch and return trending products data
            // Example data:
            return new List<ProductSaleData>
        {
            new ProductSaleData { ProductName = "Product3", QuantitySold = 150 },
            new ProductSaleData { ProductName = "Product4", QuantitySold = 250 }
        };
        }

        private List<ProductSaleData> GetDailySalesData()
        {
            // Fetch and return daily sales data
            // Example data:
            return new List<ProductSaleData>
        {
            new ProductSaleData { ProductName = "Product5", QuantitySold = 50 },
            new ProductSaleData { ProductName = "Product6", QuantitySold = 75 }
        };
        }
    }
}