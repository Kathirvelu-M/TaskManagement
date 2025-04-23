using System.Runtime.CompilerServices;
using TaskManagementService.Interfaces;
using TaskManagementUtilities.DtoModels;

namespace TaskManagement
{
    public partial class TaskManagement : Form
    {
        private readonly Lazy<ITaskService> _taskService;
        List<TaskDTO> taskList = new List<TaskDTO>();
        List<Panel> panels = new List<Panel>();
        int page = 0;
        public TaskManagement(Lazy<ITaskService> taskService)
        {
            InitializeComponent();
            _taskService = taskService;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.panels[++page].BringToFront();
        }

        private async void TaskManagement_Load(object sender, EventArgs e)
        {
            await LoadTaskList(sender, e);
            LoadData();
            panels.Add(TaskListPanel);
            panels.Add(NewTaskPanel);
            panels[page].BringToFront();
        }

        private async Task LoadTaskList(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                _taskService.Value.GetAllTasks().ContinueWith(t =>
                {
                    if (t.IsCompleted)
                    {
                        this.taskList = t.Result.ToList();
                    }
                });
            });
        }

        private void LoadData()
        {
            TaskListGrid.DataSource = null;
            TaskListGrid.DataSource = taskList;
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            HandleCreateTask(sender, e);
        }

        private async void HandleCreateTask(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskNameVal.Text) || string.IsNullOrWhiteSpace(AssigneeVal.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            TaskDTO newTask = new TaskDTO
            {
                GridTaskNameVal = TaskNameVal.Text,
                GridAssigneeVal = AssigneeVal.Text
            };
            await Task.Run(() => 
            {
                _taskService.Value.CreateTask(newTask).ContinueWith(t =>
                {
                    if (t.IsCompleted)
                    {
                        taskList.Add(newTask);
                        MessageBox.Show("Task created successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create task.");
                        return;
                    }
                });
            });
            await LoadTaskList(sender, e);
            LoadData();
            BackToTaskListBtn_Click(sender, e);
        }

        private void BackToTaskListBtn_Click(object sender, EventArgs e)
        {
            this.AssigneeVal.Text = this.TaskNameVal.Text = "";
            this.panels[--page].BringToFront();
        }
    }
}
