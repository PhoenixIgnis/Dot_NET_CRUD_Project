using Microsoft.EntityFrameworkCore;

namespace Dot_NET_CRUD_Project.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CSharpCRUDProjectDB");

        }

        public DbSet<Buildings> Buildings { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<PartNumbers> PartNumbers  { get; set; }

    }
}
