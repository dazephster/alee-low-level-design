using System;

namespace TaskManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Task Management System!");

            var manager = new TaskManager();

            User Boss = manager.CreateUser("Bossman");
            User Austin = manager.CreateUser("Austin");

            TaskItem taskOne = manager.CreateTask(Boss.Id, "Austin's Task", "Task for Austin", Austin.Id, new DateTime(2025, 8, 30), Priority.MEDIUM);

            manager.ViewLog();

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
