using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class AddBussinessService
    {
        public static IHostBuilder RegisterBussinessServices(this IHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddScoped<ICategoryService, CategoryService>();
            });
            return builder;
        }
    }
}
