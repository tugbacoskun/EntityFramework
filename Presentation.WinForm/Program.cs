using BusinessLayer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.EfCore;

namespace Presentation.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var hostBuilder = Host.CreateDefaultBuilder()
                           .RegisterPersistenceEfCoreServices()
                           .RegisterBussinessServices()
                           .RegisterUIServicesAndForms();


            var _host = hostBuilder.Build();
            _host.Start();

            var frmMain = _host.Services.GetRequiredService<FrmMain>();
            Application.Run(frmMain);

        }
    }
}