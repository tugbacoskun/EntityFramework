using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WinForm
{
    public static class AddUIServices
    {
        public static IHostBuilder RegisterUIServicesAndForms(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                services.AddScoped<FrmMain>();
            });

            return host;
        }
    }
}

