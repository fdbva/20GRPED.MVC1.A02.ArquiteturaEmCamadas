using System;
using System.Collections.Generic;
using System.Text;
using Core.Interfaces;
using Core.Services;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IoC
{
    public class Bootstrapper
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
