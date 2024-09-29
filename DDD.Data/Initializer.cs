using DDD.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Data
{
    static class Initializer
    {
        static void AddDbContext(this IServiceCollection services)
        {
            services.AddSingleton<DbContext, DataDBContext>();


        }
    }
}
