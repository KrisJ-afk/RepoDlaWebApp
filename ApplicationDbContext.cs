using AnimalShopWebApi_UG.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShopWebApi_UG
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
