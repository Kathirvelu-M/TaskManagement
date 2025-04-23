using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using TaskManagementDataAccess.Contexts;
using TaskManagementDataAccess.Interfaces;
using TaskManagementDataAccess.Repositories;
using TaskManagementUtilities.Mapper;

namespace TaskManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Create a new service collection
            var services = new ServiceCollection();
            services.AddTransient<TaskManagement>();

            await Task.Run(() =>
            {
                // Register your DbContext here  
                services.AddTransient<TaskDbContext>(sp =>
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                    var options = new DbContextOptionsBuilder<TaskDbContext>()
                                       .UseSqlServer(connectionString)
                                       .Options;
                    return new TaskDbContext(options);
                });

                // Register your services here
                var serviceRegistration = new TaskManagementService.Service_Registration.ServiceRegistration();
                serviceRegistration.RegisterServices(services);

                // Register your repositories here
                var dataAccessRegistration = new TaskManagementDataAccess.DataAccessRegistration.DataAccessRegistration();
                dataAccessRegistration.RegisterDataAccess(services);

                MapperConfigurationExpression expression = new MapperConfigurationExpression();
                expression.AddProfile(new DTOMappingProfile());
                var mapperConfiguration = new MapperConfiguration(expression);
                services.AddSingleton<IMapper>(s => mapperConfiguration.CreateMapper());
            });

            // Build the service provider
            using (var service = services.BuildServiceProvider())
            {
                var taskManagement = service.GetRequiredService<TaskManagement>();
                Application.Run(taskManagement);
            }
        }
    }
}