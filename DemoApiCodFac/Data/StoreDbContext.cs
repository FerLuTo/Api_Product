using System.Data;
using Microsoft.EntityFrameworkCore;
using DemoApiCodFac.Models;

namespace DemoApiCodFac.Data
{
    public class StoreDbContext : DbContext

    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        public DbSet<ProductEntity> Products { get; set; }

    }
}
