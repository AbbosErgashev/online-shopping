using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas.Seeds;
using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.Datas;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SuperUser();
        base.OnModelCreating(modelBuilder);
    }
}
