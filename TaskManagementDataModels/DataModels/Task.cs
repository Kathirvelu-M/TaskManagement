using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementDataModels.Entities
{
    public partial class Task
    {
        public Task() { }

        public void CreateTask(Task task)
        {
            this.TaskName = task.TaskName;
            this.Assignee = task.Assignee;
        }
    }
}
