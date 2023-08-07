using WpfAppTema1.Models; 
using Microsoft.EntityFrameworkCore;
public class RestaurantContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(@"Server=localhost;Database=MVPApp;User Id=postgres;Password=1q2w3e;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
                    .ToTable("employees");
        modelBuilder.Entity<Product>()
                    .ToTable("products");
        modelBuilder.Entity<Table>()
                    .ToTable("tables");
        modelBuilder.Entity<Order>()
                    .ToTable("orders");
        modelBuilder.Entity<User>()
                    .ToTable("users");
        // Restul configurărilor

        base.OnModelCreating(modelBuilder);
    }
}
