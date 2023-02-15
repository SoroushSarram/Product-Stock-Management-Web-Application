using Microsoft.EntityFrameworkCore;
using Soroush_Sarram_WebServer2_Midtrem.Models;

namespace Soroush_Sarram_WebServer2_Midtrem.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products 
        { 
            get; set; 
        }
    }
}

