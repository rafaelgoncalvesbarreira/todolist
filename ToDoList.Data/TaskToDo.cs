using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Model
{
    public class TaskToDo: Base
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
    }
}
