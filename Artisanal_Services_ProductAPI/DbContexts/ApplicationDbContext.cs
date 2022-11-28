using Artisanal_Services_ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Artisanal_Services_ProductAPI
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
