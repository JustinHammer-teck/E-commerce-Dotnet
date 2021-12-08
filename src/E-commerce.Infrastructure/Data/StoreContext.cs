using E_commerce.Domain.Entities;
using E_commerce.Infrastructure.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace E_commerce.Infrastructure.Data
{
    public class StoreContext : DbContext , IStoreContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}