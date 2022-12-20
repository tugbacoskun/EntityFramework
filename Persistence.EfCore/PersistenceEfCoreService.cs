using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.EfCore.Repositories;

namespace Persistence.EfCore
{
    public static class PersistenceEfCoreService
    {
        public static IHostBuilder RegisterPersistenceEfCoreServices(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>  
            {
                services.AddDbContext<PersistenceDbContext>(options => options.UseSqlServer("Server=.;Database=EntityFrameWork2;User Id=sa;Password=Test123!;TrustServerCertificate=true"));

                services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            });
            return host;
        }
    }
}