using API.DomainModel;
using DomainModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.DALInfrastructure.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
                
        }
        public DbSet<User> Users {  get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Asset> assets { get; set; }
        public DbSet<Transaction> transactions { get; set; }    

    }
}
