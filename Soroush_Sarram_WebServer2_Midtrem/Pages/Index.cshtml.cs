using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Soroush_Sarram_WebServer2_Midtrem.Data;
using Soroush_Sarram_WebServer2_Midtrem.Models;

namespace Soroush_Sarram_WebServer2_Midtrem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ApplicationDbContext _context;

        public List<Product> Products 
        { 
            get; set; 
        }

        public IndexModel(ApplicationDbContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}