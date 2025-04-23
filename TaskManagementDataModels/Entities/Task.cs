using System;
using System.Collections.Generic;

namespace TaskManagementDataModels.Entities;

public partial class Task
{
    public int TaskId { get; set; }

    public string TaskName { get; set; } = null!;

    public string? Assignee { get; set; }
}
