using E_commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Infrastructure.Common.Interfaces
{
    public interface IStoreContext
    {
         DbSet<Product> Products { get; set; }
         DbSet<ProductBrand> ProductBrands { get; set; }
         DbSet<ProductType> ProductTypes { get; set; }
    }
}
