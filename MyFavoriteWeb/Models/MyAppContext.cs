using Microsoft.EntityFrameworkCore;

namespace MyFavoriteWeb.Models
{
    public class MyAppContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyFavoriteWeb.db");
        }
    }
}
