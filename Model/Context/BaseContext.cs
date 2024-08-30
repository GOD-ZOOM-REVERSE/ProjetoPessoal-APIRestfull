using Microsoft.EntityFrameworkCore;

namespace ProjetoPessoal.Model.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
