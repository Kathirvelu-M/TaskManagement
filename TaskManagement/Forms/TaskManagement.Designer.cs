namespace TaskManagement
{
    partial class TaskManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TaskListGrid = new DataGridView();
            TaskListLabel = new Label();
            AddButton = new Button();
            TaskListPanel = new Panel();
            NewTaskPanel = new Panel();
            BackToTaskListBtn = new Button();
            CreateTaskButton = new Button();
            AssigneeVal = new TextBox();
            TaskNameVal = new TextBox();
            AssigneeLabel = new Label();
            TaskNameLabel = new Label();
            NewTask = new Label();
            Id = new DataGridViewTextBoxColumn();
            GridTaskName = new DataGridViewTextBoxColumn();
            GridTaskAssignee = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TaskListGrid).BeginInit();
            TaskListPanel.SuspendLayout();
            NewTaskPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TaskListGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TaskListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TaskListGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TaskListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TaskListGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            TaskListGrid.BackgroundColor = SystemColors.Window;
            TaskListGrid.BorderStyle = BorderStyle.None;
            TaskListGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TaskListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaskListGrid.Columns.AddRange(new DataGridViewColumn[] { Id, GridTaskName, GridTaskAssignee });
            TaskListGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            TaskListGrid.GridColor = SystemColors.Window;
            TaskListGrid.Location = new Point(5, 35);
            TaskListGrid.MultiSelect = false;
            TaskListGrid.Name = "TaskListGrid";
            TaskListGrid.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TaskListGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            TaskListGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            TaskListGrid.Size = new Size(816, 430);
            TaskListGrid.TabIndex = 0;
            // 
            // TaskListLabel
            // 
            TaskListLabel.AutoSize = true;
            TaskListLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskListLabel.Location = new Point(5, 2);
            TaskListLabel.Name = "TaskListLabel";
            TaskListLabel.Size = new Size(82, 25);
            TaskListLabel.TabIndex = 1;
            TaskListLabel.Text = "Task List";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddButton.Location = new Point(726, 5);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(87, 24);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // TaskListPanel
            // 
            TaskListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TaskListPanel.Controls.Add(AddButton);
            TaskListPanel.Controls.Add(TaskListLabel);
            TaskListPanel.Controls.Add(TaskListGrid);
            TaskListPanel.Location = new Point(12, 12);
            TaskListPanel.Name = "TaskListPanel";
            TaskListPanel.Size = new Size(828, 471);
            TaskListPanel.TabIndex = 3;
            // 
            // NewTaskPanel
            // 
            NewTaskPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewTaskPanel.Controls.Add(BackToTaskListBtn);
            NewTaskPanel.Controls.Add(CreateTaskButton);
            NewTaskPanel.Controls.Add(AssigneeVal);
            NewTaskPanel.Controls.Add(TaskNameVal);
            NewTaskPanel.Controls.Add(AssigneeLabel);
            NewTaskPanel.Controls.Add(TaskNameLabel);
            NewTaskPanel.Controls.Add(NewTask);
            NewTaskPanel.Location = new Point(12, 12);
            NewTaskPanel.Name = "NewTaskPanel";
            NewTaskPanel.Size = new Size(828, 471);
            NewTaskPanel.TabIndex = 4;
            // 
            // BackToTaskListBtn
            // 
            BackToTaskListBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BackToTaskListBtn.Location = new Point(669, 445);
            BackToTaskListBtn.Name = "BackToTaskListBtn";
            BackToTaskListBtn.Size = new Size(75, 23);
            BackToTaskListBtn.TabIndex = 7;
            BackToTaskListBtn.Text = "Back";
            BackToTaskListBtn.UseVisualStyleBackColor = true;
            BackToTaskListBtn.Click += BackToTaskListBtn_Click;
            // 
            // CreateTaskButton
            // 
            CreateTaskButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CreateTaskButton.Location = new Point(749, 445);
            CreateTaskButton.Name = "CreateTaskButton";
            CreateTaskButton.Size = new Size(76, 23);
            CreateTaskButton.TabIndex = 6;
            CreateTaskButton.Text = "Submit";
            CreateTaskButton.UseVisualStyleBackColor = true;
            CreateTaskButton.Click += CreateTaskButton_Click;
            // 
            // AssigneeVal
            // 
            AssigneeVal.Location = new Point(126, 114);
            AssigneeVal.Name = "AssigneeVal";
            AssigneeVal.Size = new Size(175, 23);
            AssigneeVal.TabIndex = 5;
            // 
            // TaskNameVal
            // 
            TaskNameVal.Location = new Point(126, 65);
            TaskNameVal.Name = "TaskNameVal";
            TaskNameVal.Size = new Size(175, 23);
            TaskNameVal.TabIndex = 4;
            // 
            // AssigneeLabel
            // 
            AssigneeLabel.AutoSize = true;
            AssigneeLabel.Location = new Point(36, 117);
            AssigneeLabel.Name = "AssigneeLabel";
            AssigneeLabel.Size = new Size(63, 15);
            AssigneeLabel.TabIndex = 2;
            AssigneeLabel.Text = "Assignee  :";
            // 
            // TaskNameLabel
            // 
            TaskNameLabel.AutoSize = true;
            TaskNameLabel.Location = new Point(30, 68);
            TaskNameLabel.Name = "TaskNameLabel";
            TaskNameLabel.Size = new Size(70, 15);
            TaskNameLabel.TabIndex = 1;
            TaskNameLabel.Text = "Task Name :";
            // 
            // NewTask
            // 
            NewTask.AutoSize = true;
            NewTask.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewTask.Location = new Point(3, 3);
            NewTask.Name = "NewTask";
            NewTask.Size = new Size(92, 25);
            NewTask.TabIndex = 0;
            NewTask.Text = "New Task";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Task Id";
            Id.Name = "Id";
            // 
            // GridTaskName
            // 
            GridTaskName.DataPropertyName = "GridTaskNameVal";
            GridTaskName.HeaderText = "Task Name";
            GridTaskName.Name = "GridTaskName";
            // 
            // GridTaskAssignee
            // 
            GridTaskAssignee.DataPropertyName = "GridAssigneeVal";
            GridTaskAssignee.HeaderText = "Assignee";
            GridTaskAssignee.Name = "GridTaskAssignee";
            // 
            // TaskManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 495);
            Controls.Add(TaskListPanel);
            Controls.Add(NewTaskPanel);
            Name = "TaskManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management";
            Load += TaskManagement_Load;
            ((System.ComponentModel.ISupportInitialize)TaskListGrid).EndInit();
            TaskListPanel.ResumeLayout(false);
            TaskListPanel.PerformLayout();
            NewTaskPanel.ResumeLayout(false);
            NewTaskPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TaskListGrid;
        private Label TaskListLabel;
        private Button AddButton;
        private Panel TaskListPanel;
        private Panel NewTaskPanel;
        private TextBox AssigneeVal;
        private TextBox TaskNameVal;
        private Label AssigneeLabel;
        private Label TaskNameLabel;
        private Label NewTask;
        private Button BackToTaskListBtn;
        private Button CreateTaskButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn GridTaskName;
        private DataGridViewTextBoxColumn GridTaskAssignee;
    }
}
