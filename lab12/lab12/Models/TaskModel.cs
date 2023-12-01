using System;
using System.Collections.Generic;
using System.Text;

namespace lab12.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public bool isCompleted { get; set; }

        public TaskModel() { }

    }
}
