using Microsoft.EntityFrameworkCore;
using projeto_loja_digital.Models;

namespace projeto_loja_digital.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
    }
}
