using AutoMapper;
using E_commerce.Domain.Entities;
using E_commerce.Infrastructure.Contracts.Products.Queries;
using Microsoft.Extensions.Configuration;


namespace E_commerce.Infrastructure.Common.Mapping
{
    public class ProductUrlResolver : IValueResolver<Product, ProductDTO, string>
    {
        private readonly IConfiguration _configuration;

        public ProductUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Resolve(Product source, 
            ProductDTO destination, 
            string destMember, 
            ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _configuration["ApiUrl"] + source.PictureUrl;
            }

            return null;
        }
    }
}
