using Dotnet_OracleDB.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_OracleDB.Context
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Product> Productos { get; set; }
    }
}
