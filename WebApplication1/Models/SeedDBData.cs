using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public partial class NorthwindContext : DbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 1,
                CategoryName = "Name01",
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 2,
                CategoryName = "Name01",
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 3,
                CategoryName = "Name01",
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 4,
                CategoryName = "Name01",

            });
        }
    }
}
