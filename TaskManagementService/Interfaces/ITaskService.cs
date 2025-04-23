using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementDataModels.Entities;
using TaskManagementUtilities.DtoModels;

namespace TaskManagementService.Interfaces
{
    public interface ITaskService
    {
        Task<IList<TaskDTO>> GetAllTasks();
        Task<TaskManagementDataModels.Entities.Task> GetTaskById(int id);
        Task<TaskManagementDataModels.Entities.Task> CreateTask(TaskDTO taskDTO);
        Task<TaskManagementDataModels.Entities.Task> UpdateTask(int id, TaskDTO taskDTO);
        Task<bool> DeleteTask(int id);
    }
}
