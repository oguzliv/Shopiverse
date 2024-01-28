using Microsoft.EntityFrameworkCore;
using Shopiverse.Models;

namespace Shopiverse.DbContexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Basket> Basket { get; set; }
    public DbSet<Order> Orders { get; set; }
}
