using AutoMapper;
using E_commerce.Domain.Entities;
using E_commerce.Infrastructure.Common.Mapping;


namespace E_commerce.Infrastructure.Contracts.Products.Queries
{
    public class ProductDTO : IMapFrom<Product>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
        public int Id { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDTO>();
        }
    }
}
