using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ExploreCalifornia.Models
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Post> Posts
        {
            get; set;
        }   // naming is super important as DBSet<T> allows entity framework to directly access the table "Posts" in the database
        public IQueryable<MonthlySpecial> MonthlySpecials
        {
            get
            {
                return new[]
                {
                    new MonthlySpecial {
                        Key = "calm",
                        Name = "California Calm Package",
                        Type = "Day Spa Package",
                        Price = 250,
                    },
                    new MonthlySpecial {
                        Key = "desert",
                        Name = "From Desert to Sea",
                        Type = "2 Day Salton Sea",
                        Price = 350,
                    },
                    new MonthlySpecial {
                        Key = "backpack",
                        Name = "Backpack Cali",
                        Type = "Big Sur Retreat",
                        Price = 620,
                    },
                    new MonthlySpecial {
                        Key = "taste",
                        Name = "Taste of California",
                        Type = "Tapas & Groves",
                        Price = 150,
                    },
                }.AsQueryable();
            }
        }

        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
