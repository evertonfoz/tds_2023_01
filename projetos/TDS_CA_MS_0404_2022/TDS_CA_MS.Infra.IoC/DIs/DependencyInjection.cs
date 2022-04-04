using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TDS_CA_MS.Domain.Interfaces;
using TDS_CA_MS.Infra.Data.DataContext;
using TDS_CA_MS.Infra.Data.Repositories;
using TDS_CA_MS.Application.Interfaces;
using TDS_CA_MS.Application.Services;
using TDS_CA_MS.Application.Mappings;
using MediatR;
using TDS_CA_MS.Application.Products.Queries;

namespace TDS_CA_MS.Infra.IoC.DIs
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<DataApplicationContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("tds_cs"),
                    b => b.MigrationsAssembly(
                        typeof(DataApplicationContext).
                        Assembly.FullName)));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            //var myHandlers = AppDomain.CurrentDomain.Load("TDS_CA_MS.Application");

            services.AddMediatR(typeof(GetProductsQuery));
            //services.AddMediatR(myHandlers);

            return services;
        }
    }

    //public static class MediatRExtension
    //{
    //    public static void Add
    //}
}
