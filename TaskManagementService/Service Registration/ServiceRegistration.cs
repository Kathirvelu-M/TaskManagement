using Microsoft.Extensions.DependencyInjection;
using TaskManagementService.Interfaces;
using TaskManagementService.Services;

namespace TaskManagementService.Service_Registration
{
    public class ServiceRegistration
    {
        public ServiceRegistration()
        {
            
        }

        public void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ITaskService, TaskService>();
            services.AddTransient(providers => new Lazy<ITaskService>(providers.GetRequiredService<ITaskService>));
        }
    }
}
