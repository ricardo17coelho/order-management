using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using order_management.Services;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace order_management
{

    [ExcludeFromCodeCoverage]
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// 
        /// The main entry point for the application.
        /// 
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Create service container object
            var services = new ServiceCollection();

            //db connStr
            var connStr = "Data Source =.; Database = OrderManagementV4; Trusted_Connection = True";

            //Add service registration
            ConfigureServices(services, connStr); 
            
            //Build serviceprovider object
            ServiceProvider = services.BuildServiceProvider();

            //Request instance service of MainForm type from service manager
            var homeScreen = ServiceProvider.GetService<View.HomeScreen>();
            Application.Run(homeScreen);
        }
        private static void ConfigureServices(ServiceCollection services, string connectionString)
        {
            //DB
            services.AddDbContext<OrderManagementDbContext>
                (Options => Options.UseSqlServer(connectionString));

            //Services Registration
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IBillService, BillService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IYoyComparisonService, YoyComparisonService>();

            //Repo Registration
            services.AddScoped<RepoCustomer>();
            services.AddScoped<RepoOrder>();
            services.AddScoped<RepoOrderDetail>();
            services.AddScoped<RepoBill>();
            services.AddScoped<RepoProduct>();
            services.AddScoped<RepoProductCategory>();
            services.AddScoped<RepoYoyComparison>();

            //Views Registration
            //First View
            services.AddSingleton(typeof(View.HomeScreen));
            //Presentation other forms will be injected here
            //Customers Views
            services.AddTransient(typeof(View.ViewCustomers));
            services.AddTransient(typeof(View.FormCustomers));
            //Categories Views
            services.AddTransient(typeof(View.ViewCategories));
            services.AddTransient(typeof(View.FormCategories));
            services.AddTransient(typeof(View.ViewCategoryTreeView));
            //Orders Views
            services.AddTransient(typeof(View.ViewOrders));
            services.AddTransient(typeof(View.FormOrders));
            //OrdersDetail Views
            services.AddTransient(typeof(View.FormOrderDetail));
            //Products Views
            services.AddTransient(typeof(View.ViewProducts));
            services.AddTransient(typeof(View.FormProducts));
            //Bills Views
            services.AddTransient(typeof(View.ViewBills));
            //YoyComparison Views
            services.AddTransient(typeof(View.ViewYoyComparison));
        }
    }
}
