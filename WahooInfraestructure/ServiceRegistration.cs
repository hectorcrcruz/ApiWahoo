using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Commons;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Services;
using WahooInfraestructure.Persistence;
using WahooInfraestructure.Repositories;

namespace WahooInfraestructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WahooDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            var AzureBlobStorage = configuration.GetSection("AzureBlobStorage");
            services.Configure<AzureBlobStorageOptions>(AzureBlobStorage);
            services.AddSingleton<BlobStorageService>();

            return services;
        }
    }
}
