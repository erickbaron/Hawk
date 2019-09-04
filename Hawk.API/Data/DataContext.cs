using Hawk.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Hawk.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
          
            public DbSet<Usuario> Usuarios { get; set; }
    }
}
