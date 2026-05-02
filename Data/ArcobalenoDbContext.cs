using Arcobaleno.Models;
using Microsoft.EntityFrameworkCore;

namespace Arcobaleno.Data
{
    public class ArcobalenoDbContext : DbContext
    {
        public ArcobalenoDbContext(DbContextOptions<ArcobalenoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<User> Users {  get; set;}
    }
}
