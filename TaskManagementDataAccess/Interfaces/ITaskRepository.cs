using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementDataAccess.Interfaces
{
    public interface ITaskRepository
    {
        Task<IList<TaskManagementDataModels.Entities.Task>> GetAllTasks();
        Task<TaskManagementDataModels.Entities.Task> GetTaskById(int id);
        Task<TaskManagementDataModels.Entities.Task> CreateTask(TaskManagementDataModels.Entities.Task task);
        Task<TaskManagementDataModels.Entities.Task> UpdateTask(int id, TaskManagementDataModels.Entities.Task task);
        Task<bool> DeleteTask(int taskId);
    }
}
