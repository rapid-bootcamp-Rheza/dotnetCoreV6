using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace dotnet_ef_core_6.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        // injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        public DbSet<CustomerEntity> CustomerEntities => Set<CustomerEntity>();
        public DbSet<RentalEntity> RentalEntities => Set<RentalEntity>();
        public DbSet<KosEntity> KosEntities => Set<KosEntity>();
        public DbSet<ShipperEntity> ShipperEntities => Set<ShipperEntity>();

    }
}
