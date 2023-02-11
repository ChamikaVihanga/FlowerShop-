using Microsoft.EntityFrameworkCore;
using TestFlower01.Shared.Entities;

namespace TestFlower01.Server.Data
{
    public class AddDbContext:DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) 
        { }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Flower> Flowers { get; set; }   
        public DbSet<Oder> Orders { get; set; }
    }
}
