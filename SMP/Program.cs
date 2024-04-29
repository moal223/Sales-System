using Microsoft.Extensions.DependencyInjection;
using SMP.BL;
using SMP.Core.Interfaces;
using SMP.EF;
using SMP.EF.Data;
using SMP.PL.Categories;
using SMP.PL.Customers;
using SMP.PL.Home;
using SMP.PL.Purchases;
using SMP.PL.Reports;
using SMP.PL.Sell;
using SMP.PL.Suppliers;

namespace SMP
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
            var services = new ServiceCollection();
            ConfigureServices(services);
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var MainWindow = serviceProvider.GetService<Main>();
            Application.Run(MainWindow);
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<Main>()
                .AddTransient<Home_UserControl>()
                .AddTransient<Sell_UserControl>()
                .AddTransient<Cat_UserControl>()
                .AddTransient<Suppliers_UserControl>()
                .AddTransient<Purchase_UserControl>()
                .AddTransient<Customers_UserControl>()
                .AddTransient<Reports_UserControl>();
        }
    }
}