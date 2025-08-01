using System;

namespace TaskManagementSystem
{
    public class ActivityLog
    {
        public readonly Guid logId;
        public Guid PerformedBy { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }


        public ActivityLog(Guid userId, string action)
        {
            this.logId = Guid.NewGuid();
            this.PerformedBy = userId;
            this.Action = action;
            this.Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"LogId: {logId}\nPerformedBy: {PerformedBy}\nAction: {Action}\nTimestamp: {Timestamp}\n";
        }
    }
}
