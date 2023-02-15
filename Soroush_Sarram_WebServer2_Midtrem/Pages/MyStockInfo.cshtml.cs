using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Soroush_Sarram_WebServer2_Midtrem.Data;
using Soroush_Sarram_WebServer2_Midtrem.Models;

namespace Soroush_Sarram_WebServer2_Midtrem.Pages
{
    public class MyStackInfoModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Product> Products
        {
            get; set;
        }

        public MyStackInfoModel(ApplicationDbContext db)
        {
            _context = db;
        }

        public double GetTotalAmount()
        {
            double tAmount = 0;
            foreach (var product in Products)
            {
                tAmount = tAmount + (product.SellPrice * product.Quantity);
            }
            return tAmount;
        }

        public double GetPriceAverage()
        {
            double tSell = 0;
            foreach (var product in Products)
            {
                tSell = tSell + product.SellPrice;
            }
            double priceAverage=tSell/Products.Count;
            return priceAverage;
        }

        public double GetTotalProfit()
        {
            double tProfit = 0;
            foreach (var product in Products)
            {
                tProfit=tProfit+((product.SellPrice-product.BuyPrice)*product.Quantity);
            }
            return tProfit;
        }

        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}
