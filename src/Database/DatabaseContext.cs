using Microsoft.EntityFrameworkCore;
using Npgsql;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;

namespace sda_onsite_2_csharp_backend_teamwork.src.Database;
public class DatabaseContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<Role>();
        modelBuilder.HasPostgresEnum<Status>();
    }
}
