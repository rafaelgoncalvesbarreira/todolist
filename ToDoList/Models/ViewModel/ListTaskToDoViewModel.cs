using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Mvc.Models.ViewModel
{
    public class ListTaskToDoViewModel
    {
        public List<TaskToDoViewModel> AwaitingTasks { get; set; }
        public List<TaskToDoViewModel> DoingTasks { get; set; }
        public List<TaskToDoViewModel> DoneTasks{ get; set; }
    }
}
