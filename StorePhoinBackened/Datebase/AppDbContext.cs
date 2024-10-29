using Microsoft.EntityFrameworkCore;
using StorePhoinBackened.Models;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}
