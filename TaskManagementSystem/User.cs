using System;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    public class User
    {
        public readonly Guid Id;
        public string Name { get; set; }
        public List<string> messages { get; set; }

        public User(string name)
        {
            this.Name = name;
            this.messages = new List<string>();
            this.Id = Guid.NewGuid();
        }
    }
}
