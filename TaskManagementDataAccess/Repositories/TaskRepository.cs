using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementDataAccess.Contexts;
using TaskManagementDataAccess.Interfaces;

namespace TaskManagementDataAccess.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskDbContext _context;
        public TaskRepository(TaskDbContext context)
        {
            _context = context;
        }

        public Task<TaskManagementDataModels.Entities.Task> CreateTask(TaskManagementDataModels.Entities.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return Task.FromResult(task);
        }

        public Task<bool> DeleteTask(int taskId)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.TaskId == taskId);
            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return Task.FromResult(true);
        }

        public async Task<IList<TaskManagementDataModels.Entities.Task>> GetAllTasks()
        {
            return await Task.FromResult(_context.Tasks.ToList());
        }

        public async Task<TaskManagementDataModels.Entities.Task> GetTaskById(int id)
        {
            return await _context.Tasks.FirstOrDefaultAsync(t => t.TaskId == id);
        }

        public Task<TaskManagementDataModels.Entities.Task> UpdateTask(int id, TaskManagementDataModels.Entities.Task task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
            return Task.FromResult(task);
        }
    }
}
