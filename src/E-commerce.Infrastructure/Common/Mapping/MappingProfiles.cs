using AutoMapper;
using E_commerce.Domain.Entities;
using E_commerce.Infrastructure.Contracts.Products.Queries;


namespace E_commerce.Infrastructure.Common.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(p => p.ProductBrand, x => x.MapFrom(source => source.ProductBrand.Name))
                .ForMember(p => p.ProductType, x => x.MapFrom(source => source.ProductType.Name))
                .ForMember(p => p.PictureUrl, x => x.MapFrom<ProductUrlResolver>());
        }


        /*public MappingProfiles()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);

                var methodInfo = type.GetMethod("Mapping")
                    ?? type.GetInterface("IMapFrom`1").GetMethod("Mapping");

                methodInfo?.Invoke(instance, new object[] { this });

            }
        }*/

    }
}
