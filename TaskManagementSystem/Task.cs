using System;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    public class TaskItem
    {
        public readonly Guid CreatedBy;
        public readonly Guid Id;
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid AssignedUser { get; set; }
        public DateTime DueDate { get; set; }
        public Priority TaskPriority { get; set; }
        public Status TaskStatus { get; set; }
        public List<Guid> WatchingUsers { get; set; }
        public List<ActivityLog> History { get; set; }
        

        public TaskItem(Guid createdBy, string name, string description, Guid assignedUser, DateTime dueDate, Priority taskPriority)
        {
            this.CreatedBy = createdBy;
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Description = description;
            this.AssignedUser = assignedUser;
            this.DueDate = dueDate;
            this.TaskPriority = taskPriority;
            this.TaskStatus = Status.PENDING;
            this.WatchingUsers = new List<Guid>();
            this.History = new List<ActivityLog>();
        }
    }
}