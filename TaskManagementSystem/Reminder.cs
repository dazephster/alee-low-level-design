using System;

namespace TaskManagementSystem
{
    public class Reminder
    {
        public DateTime RemindTime { get; set; }
        public Guid UserId { get; set; }
        public string Message { get; set; }
        public Guid TaskId { get; set; }

        public Reminder(DateTime remindTime, Guid userId, string message, Guid taskId)
        {
            this.RemindTime = remindTime;
            this.UserId = userId;
            this.Message = message;
            this.TaskId = taskId;
        }
    }
}