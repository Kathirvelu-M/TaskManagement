using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementDataAccess.Interfaces;
using TaskManagementDataAccess.Repositories;

namespace TaskManagementDataAccess.DataAccessRegistration
{
    public class DataAccessRegistration
    {
        public DataAccessRegistration() { }

        public void RegisterDataAccess(IServiceCollection services)
        {
            services.AddTransient<ITaskRepository, TaskRepository>();
            services.AddTransient(providers => new Lazy<ITaskRepository>(providers.GetRequiredService<ITaskRepository>));
        }
    }
}
