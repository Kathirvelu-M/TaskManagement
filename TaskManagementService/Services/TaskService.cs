using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementDataAccess.Interfaces;
using TaskManagementService.Interfaces;
using TaskManagementUtilities.DtoModels;

namespace TaskManagementService.Services
{
    public class TaskService : ITaskService
    {
        private readonly Lazy<ITaskRepository> _taskRepository;
        private readonly IMapper _mapper;
        public TaskService(Lazy<ITaskRepository> taskRepository, IMapper mapper)
        {
            _mapper = mapper;
            _taskRepository = taskRepository;
        }

        public Task<TaskManagementDataModels.Entities.Task> CreateTask(TaskDTO taskDTO)
        {
            TaskManagementDataModels.Entities.Task task = _mapper.Map<TaskManagementDataModels.Entities.Task>(taskDTO);
            task.TaskId = 0; // Ensure the TaskId is set to 0 for new tasks
            return _taskRepository.Value.CreateTask(task);
        }

        public Task<bool> DeleteTask(int id)
        {
            return _taskRepository.Value.DeleteTask(id);
        }

        public async Task<IList<TaskDTO>> GetAllTasks()
        {
            var tasks = await _taskRepository.Value.GetAllTasks();
            return _mapper.Map<IList<TaskDTO>>(tasks);
        }

        public Task<TaskManagementDataModels.Entities.Task> GetTaskById(int id)
        {
            return _taskRepository.Value.GetTaskById(id);
        }

        public Task<TaskManagementDataModels.Entities.Task> UpdateTask(int id, TaskDTO taskDTO)
        {
            return _taskRepository.Value.UpdateTask(id, _mapper.Map<TaskManagementDataModels.Entities.Task>(taskDTO));
        }
    }
}
