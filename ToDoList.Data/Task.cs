using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Model
{
    public class Task: Base
    {
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
    }
}
