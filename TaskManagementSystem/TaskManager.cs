using System;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    public class TaskManager
    {
        //Keep track of users, tasks, reminders,
        private Dictionary<Guid, User> Users;
        private Dictionary<Guid, TaskItem> Tasks;
        private List<Reminder> Reminders;
        private List<ActivityLog> ManagerLog;

        public TaskManager()
        {
            this.Users = new Dictionary<Guid, User>();
            this.Tasks = new Dictionary<Guid, TaskItem>();
            this.Reminders = new List<Reminder>();
            this.ManagerLog = new List<ActivityLog>();
        }

        public User CreateUser(string name)
        {
            var newUser = new User(name);
            this.Users.Add(newUser.Id, newUser);
            this.ManagerLog.Add(new ActivityLog(Guid.Empty, $"Added new User {newUser.Id}, {newUser.Name}"));
            return newUser;
        }

        public TaskItem CreateTask(Guid createdBy, string taskName, string taskDescription, Guid assignedUser, DateTime dueDate, Priority priority)
        {
            var newTask = new TaskItem(createdBy, taskName, taskDescription, assignedUser, dueDate, priority);
            this.Tasks.Add(newTask.Id, newTask);
            this.ManagerLog.Add(new ActivityLog(createdBy, $"Added new TaskItem {newTask.Id}, {newTask.Name}"));
            return newTask;
        }

        public void ViewLog()
        {
            Console.WriteLine("Viewing Main Activity Log");
            foreach(var log in this.ManagerLog)
            {
                Console.WriteLine(log.ToString());
            }
            Console.WriteLine();
        }
    }
}
