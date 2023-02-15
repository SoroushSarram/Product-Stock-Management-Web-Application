using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Soroush_Sarram_WebServer2_Midtrem.Data;
using Soroush_Sarram_WebServer2_Midtrem.Models;

namespace Soroush_Sarram_WebServer2_Midtrem.Pages
{
    public class DeleteModel: PageModel
    {
        [BindProperty]
        public Product Product 
        { 
            get;
            set;
        }
        private readonly ApplicationDbContext _context;


        public DeleteModel(ApplicationDbContext db)
        {
            _context = db;
        }

        public async Task<IActionResult> OnGet(string id)
        {
            Product = _context.Products.Find(id);
            return Page();
        }

        public async Task<IActionResult> OnPost(string Id)
        {
            var productToDelete = _context.Products.Find(Id);
            if (productToDelete != null)
            {
                _context.Remove(productToDelete);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("Index");
        }
    }
}
