using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleIDP.Models
{
    public class Task
    {
        public Guid TaskId { get; set; }

        public string TaskName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public int TaskStatus { get; set; }
    }
}
