using E_commerce.Domain.Error;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace E_commerce.API.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {

            // Override the Default Validation Error Handling => Have a consistent Error Response 
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    var errors = actionContext.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .SelectMany(x => x.Value.Errors)
                    .Select(x => x.ErrorMessage).ToArray();
                    var errorResponse = new ValidationResponse
                    {
                        Errors = errors
                    };

                    return new BadRequestObjectResult(errorResponse);
                };
            });

            return services;
        }
    }
}
