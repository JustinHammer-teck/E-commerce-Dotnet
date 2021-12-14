using E_commerce.Infrastructure.Common.Interfaces;
using E_commerce.Infrastructure.Common.Mapping;
using E_commerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace E_commerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenericRepository<>) , typeof(GenericRepository<>));
            
            services.AddAutoMapper(typeof(MappingProfiles));
            
            services.AddDbContext<StoreContext>(x =>
                x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }    
    }
}
