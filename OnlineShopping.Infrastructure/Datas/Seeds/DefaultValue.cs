using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.Datas.Seeds;

public static partial class DefaultValue
{
    public static void SuperUser(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "Abbos",
                LastName = "Ergashev",
                Address = "Tashkent",
                Phone = "+998939887773",
            });
    }
}
