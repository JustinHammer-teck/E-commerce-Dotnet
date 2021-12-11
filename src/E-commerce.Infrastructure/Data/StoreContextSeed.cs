using E_commerce.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
    
namespace E_commerce.Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context
            , ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.ProductBrands.Any())
                {
                    var brandsData = await File.ReadAllTextAsync("../E-commerce.Infrastructure/Data/Seed/brands.json");

                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    if (brands != null)
                        foreach (var item in brands)
                        {
                            await context.ProductBrands.AddAsync(item);
                        }

                    await context.SaveChangesAsync();

                }

                if (!context.ProductTypes.Any())
                {
                    var typesData = await File.ReadAllTextAsync("../E-commerce.Infrastructure/Data/Seed/types.json");

                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    if (types != null)
                        foreach (var item in types)
                        {
                            await context.ProductTypes.AddAsync(item);
                        }

                    await context.SaveChangesAsync();

                }

                if (!context.Products.Any())
                {
                    var productsData = File.ReadAllText("../E-commerce.Infrastructure/Data/Seed/products.json");

                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    if (products != null)
                        foreach (var item in products)
                        {
                            await context.Products.AddAsync(item);
                        }

                    await context.SaveChangesAsync();

                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();

                logger.LogError(e.Message);
            }
        }

        private static Stream List<T>(string bransData)
        {
            throw new NotImplementedException();
        }
    }
}
